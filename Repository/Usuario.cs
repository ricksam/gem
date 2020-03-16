using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;
using GEM.Models;
using GEM.Helpers;

namespace GEM.Repository
{
    public class Usuario : BaseEntity<Usuario> 
    {
        public int Cod_Usuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public bool Aluno { get; set; }
        public bool Instrutor { get; set; }
        public bool Oficializado { get; set; }
        public bool Admin { get; set; }
        public bool Ativo { get; set; }
        public bool RJM{ get; set; }
        public bool Dev{ get; set; }
        public int? Cod_Instrumento { get; set; }
        //public int? Cod_Grupo { get; set; }
        public int Cod_Comum { get; set; }
        public string Observacao { get; set; }
        public string RecuperarSenha { get; set; }
        public string Token { get; set; }
        public int AvisoLido { get; set; }

        // External
        public string Comum { get; set; }
        public string Grupos { get; set; }
        public string Instrumento { get; set; }
        public int[] Cod_Grupos { get; set; }

        public static Totalizadores Totais(int Cod_Comum, Context cx = null){
            if (cx == null)
            { cx = new Context(); }

            List<int> list = cx.Query<int>(
                    @"
                    select count(u.Cod_Usuario) from Usuario u where u.Ativo = 1 and u.Instrutor = 1 and u.Cod_Comum = @Cod_Comum
                    union all
                    select count(u.Cod_Usuario) from Usuario u where u.Ativo = 1 and u.Oficializado = 1 and u.Cod_Comum = @Cod_Comum
                    union all
                    select count(u.Cod_Usuario) from Usuario u where u.Ativo = 1 and u.RJM = 1 and u.Cod_Comum = @Cod_Comum
                    union all
                    select count(u.Cod_Usuario) from Usuario u where u.Ativo = 1 and u.Aluno = 1 and u.Cod_Comum = @Cod_Comum
                    "
                    , new { Cod_Comum }).ToList();

            return new Totalizadores(){
                Instrutores = list[0],
                Oficializados = list[1],
                RJM = list[2],
                Alunos = list[3]
            };
        }

        public static bool EmailJaCadastrado(string Email, int Cod_Usuario, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return (cx.Query<int?>(
                    @"select 
                        count(u.Cod_Usuario)
                    from Usuario u
                    inner join Comum c on c.Cod_Comum = u.Cod_Comum 
                    where Email = @Email and Cod_Usuario <> @Cod_Usuario", new { Email, Cod_Usuario }).SingleOrDefault() ?? 0) != 0;
        }
        
        public static Usuario Find(int Cod_Usuario, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Usuario>(
                    @"select 
                        u.Cod_Usuario
                       ,u.Nome
                       ,u.Email
                       ,u.Telefone
                       ,u.Endereco
                       ,u.Aluno
                       ,u.Instrutor
                       ,u.Oficializado
                       ,u.Admin
                       ,u.Dev
                       ,u.RJM
                       ,u.Ativo
                       ,u.Cod_Instrumento
                       --,u.Cod_Grupo
                       ,u.Cod_Comum
                       ,u.AvisoLido
                       ,u.Observacao
                       --,g.Nome as Grupo
                       ,i.Nome as Instrumento
                    from Usuario u
                    --left outer join Grupo g on g.Cod_Grupo = u.Cod_Grupo
                    left outer join Instrumento i on i.Cod_Instrumento = u.Cod_Instrumento
                    where u.Cod_Usuario = @Cod_Usuario", new { Cod_Usuario }).FirstOrDefault();
        }

        public static Usuario FindByRecuperarSenha(string RecuperarSenha, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Usuario>(
                    @"select 
                        Cod_Usuario
                       ,Nome
                       ,Email
                       ,Telefone
                       ,Endereco
                       ,Aluno
                       ,Instrutor
                       ,Oficializado
                       ,Admin
                       ,Dev
                       ,RJM
                       ,Ativo
                       ,Cod_Instrumento
                       --,Cod_Grupo
                       ,Cod_Comum
                       ,AvisoLido
                       ,Observacao
                       ,RecuperarSenha
                    from Usuario where RecuperarSenha = @RecuperarSenha", new { RecuperarSenha }).FirstOrDefault();
        }

        public static Usuario FindByEmail(string Email, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Usuario>(
                    @"select 
                        u.Cod_Usuario
                       ,u.Nome
                       ,u.Email
                       ,u.Senha
                       ,u.Telefone
                       ,u.Endereco
                       ,u.Aluno
                       ,u.Instrutor
                       ,u.Oficializado
                       ,u.Admin
                       ,u.Dev
                       ,u.RJM
                       ,u.Ativo
                       ,u.Cod_Instrumento
                       --,u.Cod_Grupo
                       ,u.Cod_Comum
                       ,u.AvisoLido
                       ,u.Observacao
                       ,c.Nome as Comum
                    from Usuario u
                    inner join Comum c on c.Cod_Comum = u.Cod_Comum 
                    where Email = @Email", new { Email }).FirstOrDefault();
        }
        
        public static List<Usuario> ListByComum(int Cod_Comum, int Cod_Grupo = 0, string filtro = "", string status = "", int[] categoria_instrumento = null, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            string status_ativo = (status == "Ativo" ? "and u.Ativo = 1" : "");
            string status_inativo = (status == "Inativo" ? "and (u.Ativo = 0 or u.Ativo is null)" : "");

            string filtro_oficializados = (filtro=="Oficializados" ? "and u.Oficializado = 1" : "");
            string filtro_instrutores = (filtro=="Instrutores" ? "and u.Instrutor = 1" : "");
            string filtro_rjm = (filtro=="RJM" ? "and u.RJM = 1" : "");
            string filtro_alunos = (filtro=="Alunos" ? "and u.Aluno = 1" : "");

            string filtro_grupo = (Cod_Grupo!=0 ? string.Format("and u.Cod_Usuario in (select Cod_Usuario from UsuarioGrupo where Cod_Grupo = {0})", Cod_Grupo) : "");
            string filtro_instrumento = (categoria_instrumento!=null ? string.Format("and i.Cod_Categoria in ({0})", String.Join(',', categoria_instrumento)) : "");

            var list = cx.Query<Usuario>(
                string.Format(@"select
                        u.Cod_Usuario
                       ,u.Nome 
                       ,u.Email 
                       ,u.Telefone 
                       ,u.Endereco 
                       ,u.Aluno 
                       ,u.Instrutor 
                       ,u.Oficializado 
                       ,u.Admin
                       ,u.Dev
                       ,u.RJM
                       ,u.Ativo
                       ,u.Cod_Instrumento 
                       --,u.Cod_Grupo
                       ,u.Cod_Comum 
                       ,u.AvisoLido
                       ,u.Observacao
                       ,LEN(u.RecuperarSenha) as RecuperarSenha
                       --,g.Nome as Grupo 
                       ,i.Nome as Instrumento
                    from Usuario u
                    --left outer join Grupo g on g.Cod_Grupo = u.Cod_Grupo
                    left outer join Instrumento i on i.Cod_Instrumento = u.Cod_Instrumento 
                        where u.Cod_Comum = @Cod_Comum {0} {1} {2} {3} {4} {5} {6} {7}",
                        filtro_grupo, 
                        status_ativo,
                        status_inativo,
                        filtro_oficializados, 
                        filtro_instrutores, 
                        filtro_rjm,
                        filtro_alunos,
                        filtro_instrumento)
                , new {  Cod_Comum }).ToList();

            List<UsuarioGrupo> grupos = UsuarioGrupo.ListByUusarios(list.Select(e => e.Cod_Usuario).ToArray(), cx);

            foreach (var item in list)
            {
                item.Cod_Grupos = grupos.Where(e => e.Cod_Usuario == item.Cod_Usuario).Select(e => e.Cod_Grupo).ToArray();
                item.Grupos = string.Join(", ", Grupo.ListIn(item.Cod_Grupos, Cod_Comum).Select(e => e.Nome).ToArray());
            }

            return list;
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Usuario (
                        Nome,
                        Email,
                        Telefone,
                        Endereco,
                        Cod_Instrumento,
                        Cod_Comum,
                        Observacao
                    ) {0} values (
                        @Nome,
                        @Email,
                        @Telefone,
                        @Endereco,
                        @Cod_Instrumento,
                        @Cod_Comum,
                        @Observacao
                    ) {1}", "Cod_Usuario"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Usuario set 
                        Nome=@Nome, 
                        Email=@Email, 
                        Telefone=@Telefone, 
                        Endereco=@Endereco,  
                        Cod_Instrumento=@Cod_Instrumento,
                        Cod_Comum=@Cod_Comum,
                        Observacao=@Observacao 
                    where Cod_Usuario = @Cod_Usuario", this);
        }

        public void UpdateSenha(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Usuario set 
                        Senha=@Senha  
                    where Cod_Usuario = @Cod_Usuario", this);
        }

        public void UpdateRecuperarSenha(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Usuario set 
                        RecuperarSenha=@RecuperarSenha  
                    where Cod_Usuario = @Cod_Usuario", this);
        }

        public void UpdateToken(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Usuario set 
                        Token=@Token  
                    where Cod_Usuario = @Cod_Usuario", this);
        }

        public void UpdateAvisoLido(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Usuario set 
                        AvisoLido=@AvisoLido  
                    where Cod_Usuario = @Cod_Usuario", this);
        }
        
        public void Save(Context cx = null)
        {
            if(this.Cod_Usuario == 0)
                this.Cod_Usuario = Insert(cx);
            else
                Update(cx);    
            MemoryContext.CleanCache<List<UsuarioComum>>(this.Cod_Comum);  
            MemoryContext.CleanCache<Dash>(this.Cod_Comum);  
        }
        
        public static void Delete(int Cod_Usuario, int Cod_Comum, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Usuario where Cod_Usuario = @Cod_Usuario and Cod_Comum = @Cod_Comum", new { Cod_Usuario, Cod_Comum });
            MemoryContext.CleanCache<List<UsuarioComum>>(Cod_Comum);
            MemoryContext.CleanCache<Dash>(Cod_Comum);
        }        
    }
}
