using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class FaltaJustificada : BaseEntity<FaltaJustificada> 
    {
        public int Cod_Justificativa { get; set; }
        public int Cod_Usuario { get; set; }
        public int Instrutor { get; set; }
        public DateTime Data { get; set; }
        public string Justificativa { get; set; }
        
        public static FaltaJustificada Find(int Cod_Justificativa, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<FaltaJustificada>(
                    @"select 
                        Cod_Justificativa
                       ,Cod_Usuario
                       ,Instrutor
                       ,Data
                       ,Justificativa
                    from FaltaJustificada where Cod_Justificativa = @Cod_Justificativa", new { Cod_Justificativa = Cod_Justificativa }).FirstOrDefault();
        }
        
        public static List<FaltaJustificada> List(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<FaltaJustificada>(
                    @"select
                        Cod_Justificativa
                       ,Cod_Usuario 
                       ,Instrutor 
                       ,Data 
                       ,Justificativa 
                    from FaltaJustificada").ToList();
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into FaltaJustificada (
                        Cod_Usuario,
                        Instrutor,
                        Data,
                        Justificativa
                    ) {0} values (
                        @Cod_Usuario,
                        @Instrutor,
                        @Data,
                        @Justificativa
                    ) {1}", "Cod_Justificativa"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update FaltaJustificada set 
                        Cod_Usuario=@Cod_Usuario, 
                        Instrutor=@Instrutor, 
                        Data=@Data, 
                        Justificativa=@Justificativa 
                    where Cod_Justificativa = @Cod_Justificativa", this);
        }
        
        public void Save(Context cx = null)
        {
            if(this.Cod_Justificativa == 0)
                this.Cod_Justificativa = Insert(cx);
            else
                Update(cx);        
        }
        
        public static void Delete(int Cod_Justificativa, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from FaltaJustificada where Cod_Justificativa = @Cod_Justificativa", new { Cod_Justificativa = Cod_Justificativa });
        }        
    }
}
