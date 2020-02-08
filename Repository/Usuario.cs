using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

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
        public int? Cod_Instrumento { get; set; }
        public int Cod_Comum { get; set; }
        public string Observacao { get; set; }
        public string RecuperarSenha { get; set; }

        // External
        public string Comum { get; set; }
        public string Instrumento { get; set; }
        
        public static Usuario Find(int Cod_Usuario, Context cx = null)
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
                       ,Cod_Instrumento
                       ,Cod_Comum
                       ,Observacao
                    from Usuario where Cod_Usuario = @Cod_Usuario", new { Cod_Usuario = Cod_Usuario }).FirstOrDefault();
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
                       ,Cod_Instrumento
                       ,Cod_Comum
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
                       ,u.Cod_Instrumento
                       ,u.Cod_Comum
                       ,u.Observacao
                       ,c.Nome as Comum
                    from Usuario u
                    inner join Comum c on c.Cod_Comum = u.Cod_Comum 
                    where Email = @Email", new { Email }).FirstOrDefault();
        }
        
        public static List<Usuario> ListByComum(int Cod_Comum, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            //string filtro_oficializados = (tipo=="Oficializados"?"and u.Oficializado = 1":"");
            //string filtro_instrutores = (tipo=="Instrutores"?"and u.Instrutor = 1":"");
            //string filtro_alunos = (tipo=="Alunos"?"and u.Aluno = 1":"");

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
                       ,u.Cod_Instrumento 
                       ,u.Cod_Comum 
                       ,u.Observacao 
                       ,i.Nome as Instrumento
                    from Usuario u
                    left outer join Instrumento i on i.Cod_Instrumento = u.Cod_Instrumento 
                        where Cod_Comum = @Cod_Comum", new {  Cod_Comum }).ToList();
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
                        Aluno,
                        Instrutor,
                        Oficializado,
                        Admin,
                        Cod_Instrumento,
                        Cod_Comum,
                        Observacao
                    ) {0} values (
                        @Nome,
                        @Email,
                        @Telefone,
                        @Endereco,
                        @Aluno,
                        @Instrutor,
                        @Oficializado,
                        @Admin,
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
                        Aluno=@Aluno, 
                        Instrutor=@Instrutor, 
                        Oficializado=@Oficializado,
                        Admin=@Admin, 
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
        
        public void Save(Context cx = null)
        {
            if(this.Cod_Usuario == 0)
                this.Cod_Usuario = Insert(cx);
            else
                Update(cx);        
        }
        
        public static void Delete(int Cod_Usuario, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Usuario where Cod_Usuario = @Cod_Usuario", new { Cod_Usuario = Cod_Usuario });
        }        
    }
}
