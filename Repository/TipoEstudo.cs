using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class TipoEstudo : BaseEntity<TipoEstudo> 
    {
        public int Cod_Tipo { get; set; }
        public string Nome { get; set; }
        public string Controle { get; set; }
        
        public static TipoEstudo Find(int Cod_Tipo, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<TipoEstudo>(
                    @"select 
                        Cod_Tipo
                       ,Nome
                       ,Controle
                    from TipoEstudo where Cod_Tipo = @Cod_Tipo", new { Cod_Tipo = Cod_Tipo }).FirstOrDefault();
        }
        
        public static List<TipoEstudo> List(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<TipoEstudo>(
                    @"select
                        Cod_Tipo
                       ,Nome
                       ,Controle 
                    from TipoEstudo").ToList();
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into TipoEstudo (
                        Nome,
                        Controle
                    ) {0} values (
                        @Nome,
                        @Controle
                    ) {1}", "Cod_Tipo"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update TipoEstudo set 
                        Nome=@Nome,
                        Controle=@Controle 
                    where Cod_Tipo = @Cod_Tipo", this);
        }
        
        public void Save(Context cx = null)
        {
            if(this.Cod_Tipo == 0)
                this.Cod_Tipo = Insert(cx);
            else
                Update(cx);        
        }
        
        public static void Delete(int Cod_Tipo, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from TipoEstudo where Cod_Tipo = @Cod_Tipo", new { Cod_Tipo = Cod_Tipo });
        }        
    }
}
