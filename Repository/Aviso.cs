using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class Aviso : BaseEntity<Aviso> 
    {
        public int Cod_Aviso { get; set; }
        public int Cod_Usuario { get; set; }
        public int Cod_Comum { get; set; }
        public string Nome { get; set; }
        public string Mensagem { get; set; }
        public bool Aluno { get; set; }
        public bool Instrutor { get; set; }
        public bool Oficializado { get; set; }
        public bool RJM { get; set; }

        // External
        public string Usuario { get; set; }
        
        public static Aviso Find(int Cod_Aviso, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Aviso>(
                    @"select 
                        Cod_Aviso
                       ,Cod_Usuario
                       ,Cod_Comum
                       ,Nome
                       ,Mensagem
                       ,Aluno
                       ,Instrutor
                       ,Oficializado
                       ,RJM
                    from Aviso where Cod_Aviso = @Cod_Aviso", new { Cod_Aviso = Cod_Aviso }).FirstOrDefault();
        }
        
        public static List<Aviso> List(int Cod_Comum, bool Admin, bool Instrutor, bool Oficializado, bool RJM, bool Aluno, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            List<string> filtros = new List<string>();
            if(Instrutor){
                filtros.Add("a.Instrutor = 1");
            }
            if(Oficializado){
                filtros.Add("a.Oficializado = 1");
            }
            if(RJM){
                filtros.Add("a.RJM = 1");
            }
            if(Aluno){
                filtros.Add("a.Aluno = 1");
            }

            if(Admin){
                filtros.Clear();
            }
            
            return cx.Query<Aviso>(
                string.Format(
                    @"select
                        a.Cod_Aviso
                       ,a.Cod_Usuario
                       ,a.Cod_Comum 
                       ,a.Nome
                       ,a.Mensagem 
                       ,a.Aluno 
                       ,a.Instrutor 
                       ,a.Oficializado 
                       ,a.RJM 
                       ,u.Nome as Usuario
                    from Aviso a
                    inner join Usuario u on u.Cod_Usuario = a.Cod_Usuario
                    where a.Cod_Comum = @Cod_Comum {0}",
                        (filtros.Count!=0? string.Format(" and ({0}) ",String.Join(" or ", filtros)) :"")
                    ), new{ Cod_Comum }).ToList();
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Aviso (
                        Cod_Usuario,
                        Cod_Comum,
                        Nome,
                        Mensagem,
                        Aluno,
                        Instrutor,
                        Oficializado,
                        RJM
                    ) {0} values (
                        @Cod_Usuario,
                        @Cod_Comum,
                        @Nome,
                        @Mensagem,
                        @Aluno,
                        @Instrutor,
                        @Oficializado,
                        @RJM
                    ) {1}", "Cod_Aviso"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Aviso set 
                        Cod_Usuario=@Cod_Usuario, 
                        Cod_Comum=@Cod_Comum,
                        Nome=@Nome,
                        Mensagem=@Mensagem, 
                        Aluno=@Aluno, 
                        Instrutor=@Instrutor, 
                        Oficializado=@Oficializado, 
                        RJM=@RJM 
                    where Cod_Aviso = @Cod_Aviso", this);
        }
        
        public void Save(Context cx = null)
        {
            if(this.Cod_Aviso == 0)
                this.Cod_Aviso = Insert(cx);
            else
                Update(cx);        
        }
        
        public static void Delete(int Cod_Aviso, int Cod_Comum, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Aviso where Cod_Aviso = @Cod_Aviso and Cod_Comum = @Cod_Comum", new { Cod_Aviso, Cod_Comum });
        }        
    }
}
