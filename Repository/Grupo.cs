using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;
using GEM.Helpers;

namespace GEM.Repository
{
    public class Grupo : BaseEntity<Grupo> 
    {
        public int Cod_Grupo { get; set; }
        public string Nome { get; set; }
        public int Cod_Comum { get; set; }
        
        public static Grupo Find(int Cod_Grupo, int Cod_Comum = 0, Context cx = null){
            return List(Cod_Comum).FirstOrDefault(e=>e.Cod_Grupo == Cod_Grupo);
        }

        public static List<Grupo> ListIn(int[] Cod_Grupos, int Cod_Comum = 0, Context cx = null) {
            return List(Cod_Comum).Where(e => { return Cod_Grupos.Contains(e.Cod_Grupo); }).ToList();
        }

        public static List<Grupo> List(int Cod_Comum = 0, Context cx = null)
        {
            var list = MemoryContext.GetCache<List<Grupo>>(Cod_Comum); 
            if(list.Count == 0){
                if (cx == null)
                { cx = new Context(); }
                
                list = cx.Query<Grupo>(
                        @"select
                            Cod_Grupo
                        ,Nome 
                        ,Cod_Comum 
                        from Grupo
                        where Cod_Comum = @Cod_Comum", new { Cod_Comum }).ToList();
                MemoryContext.SetCache<List<Grupo>>(list, Cod_Comum);
            }
            return list;
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Grupo (
                        Nome,
                        Cod_Comum
                    ) {0} values (
                        @Nome,
                        @Cod_Comum
                    ) {1}", "Cod_Grupo"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Grupo set 
                        Nome=@Nome, 
                        Cod_Comum=@Cod_Comum 
                    where Cod_Grupo = @Cod_Grupo", this);
        }
        
        public void Save(Context cx = null)
        {
            if(this.Cod_Grupo == 0)
                this.Cod_Grupo = Insert(cx);
            else
                Update(cx);

            MemoryContext.CleanCache<List<Grupo>>(Cod_Comum);
        }
        
        public static void Delete(int Cod_Grupo, int Cod_Comum, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Grupo where Cod_Grupo = @Cod_Grupo", new { Cod_Grupo = Cod_Grupo });
            
            MemoryContext.CleanCache<List<Grupo>>(Cod_Comum);
        }        
    }
}
