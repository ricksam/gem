using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class Comum : BaseEntity<Comum> 
    {
        public int Cod_Comum { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Endereco { get; set; }
        
        public static Comum Find(int Cod_Comum, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Comum>(
                    @"select 
                        Cod_Comum
                       ,Nome
                       ,Cidade
                       ,Estado
                       ,Endereco
                    from Comum where Cod_Comum = @Cod_Comum", new { Cod_Comum = Cod_Comum }).FirstOrDefault();
        }
        
        public static List<Comum> List(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Comum>(
                    @"select
                        Cod_Comum
                       ,Nome 
                       ,Cidade 
                       ,Estado 
                       ,Endereco 
                    from Comum").ToList();
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Comum (
                        Nome,
                        Cidade,
                        Estado,
                        Endereco
                    ) {0} values (
                        @Nome,
                        @Cidade,
                        @Estado,
                        @Endereco
                    ) {1}", "Cod_Comum"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Comum set 
                        Nome=@Nome, 
                        Cidade=@Cidade, 
                        Estado=@Estado, 
                        Endereco=@Endereco 
                    where Cod_Comum = @Cod_Comum", this);
        }
        
        public void Save(Context cx = null)
        {
            if(this.Cod_Comum == 0)
                this.Cod_Comum = Insert(cx);
            else
                Update(cx);        
        }
        
        public static void Delete(int Cod_Comum, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Comum where Cod_Comum = @Cod_Comum", new { Cod_Comum = Cod_Comum });
        }        
    }
}
