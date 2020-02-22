using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;
using GEM.Helpers;

namespace GEM.Repository
{
    public class Categoria : BaseEntity<Categoria> 
    {
        public int Cod_Categoria { get; set; }
        public string Nome { get; set; }
        
        public static Categoria Find(int Cod_Categoria, Context cx = null)
        {
            return List(cx).FirstOrDefault(e=>e.Cod_Categoria == Cod_Categoria);
        }
        
        public static List<Categoria> List(Context cx = null)
        {
            var list = MemoryContext.GetCache<List<Categoria>>();
            if (list.Count == 0)
            {
                if (cx == null)
                { cx = new Context(); }

                list = cx.Query<Categoria>(
                    @"select
                        Cod_Categoria
                       ,Nome 
                    from Categoria").ToList();
                MemoryContext.SetCache<List<Categoria>>(list);
            }
            return list;
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Categoria (
                        Nome
                    ) {0} values (
                        @Nome
                    ) {1}", "Cod_Categoria"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Categoria set 
                        Nome=@Nome 
                    where Cod_Categoria = @Cod_Categoria", this);
        }

        public void Save(Context cx = null)
        {
            if(this.Cod_Categoria == 0)
                this.Cod_Categoria = Insert(cx);
            else
                Update(cx);   
            MemoryContext.CleanCache<List<Categoria>>();     
        }
        
        public static void Delete(int Cod_Categoria, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Categoria where Cod_Categoria = @Cod_Categoria", new { Cod_Categoria = Cod_Categoria });
            MemoryContext.CleanCache<List<Categoria>>();
        }        
    }
}
