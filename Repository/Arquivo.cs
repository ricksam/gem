using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class Arquivo : BaseEntity<Arquivo> 
    {
        public int Cod_Arquivo { get; set; }
        public int Cod_Usuario { get; set; }
        public int Cod_Comum { get; set; }
        public string Url { get; set; }
        public bool Aluno { get; set; }
        public bool Instrutor { get; set; }
        public bool Oficializado { get; set; }
        public bool RJM { get; set; }

        //External
        public string Usuario { get; set; }
        
        public static Arquivo Find(int Cod_Arquivo, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Arquivo>(
                    @"select 
                        a.Cod_Arquivo
                       ,a.Cod_Usuario
                       ,a.Cod_Comum
                       ,a.Url
                       ,a.Aluno
                       ,a.Instrutor
                       ,a.Oficializado
                       ,a.RJM
                    from Arquivo a 
                    where a.Cod_Arquivo = @Cod_Arquivo", new { Cod_Arquivo = Cod_Arquivo }).FirstOrDefault();
        }
        
        public static List<Arquivo> List(int Cod_Comum, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Arquivo>(
                    @"select
                        a.Cod_Arquivo
                       ,a.Cod_Usuario
                       ,a.Cod_Comum 
                       ,a.Url 
                       ,a.Aluno 
                       ,a.Instrutor 
                       ,a.Oficializado 
                       ,a.RJM
                       ,u.Nome as Usuario 
                    from Arquivo a
                    inner join Usuario u on u.Cod_Usuario = a.Cod_Usuario
                    where a.Cod_Comum = @Cod_Comum", new{Cod_Comum}).ToList();
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Arquivo (
                        Cod_Usuario,
                        Cod_Comum,
                        Url,
                        Aluno,
                        Instrutor,
                        Oficializado,
                        RJM
                    ) {0} values (
                        @Cod_Usuario,
                        @Cod_Comum,
                        @Url,
                        @Aluno,
                        @Instrutor,
                        @Oficializado,
                        @RJM
                    ) {1}", "Cod_Arquivo"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Arquivo set 
                        Cod_Usuario=@Cod_Usuario, 
                        Cod_Comum=@Cod_Comum,
                        Url=@Url, 
                        Aluno=@Aluno, 
                        Instrutor=@Instrutor, 
                        Oficializado=@Oficializado, 
                        RJM=@RJM 
                    where Cod_Arquivo = @Cod_Arquivo", this);
        }
        
        public void Save(Context cx = null)
        {
            if(this.Cod_Arquivo == 0)
                this.Cod_Arquivo = Insert(cx);
            else
                Update(cx);        
        }
        
        public static void Delete(int Cod_Arquivo, int Cod_Comum, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Arquivo where Cod_Arquivo = @Cod_Arquivo and Cod_Comum = @Cod_Comum", new { Cod_Arquivo, Cod_Comum });
        }        
    }
}
