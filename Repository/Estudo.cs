using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class Estudo : BaseEntity<Estudo> 
    {
        public int Cod_Estudo { get; set; }
        public int Cod_Presenca { get; set; }
        public int Cod_Tipo { get; set; }
        public int Numero { get; set; }
        public string Observacao { get; set; }
        public int Instrutor { get; set; }

        /*external*/
        public string Tipo { get; set; }
        public string Nome_Instrutor { get; set; }
        
        public static Estudo Find(int Cod_Estudo, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Estudo>(
                    @"select 
                        Cod_Estudo
                       ,Cod_Presenca
                       ,Cod_Tipo
                       ,Numero
                       ,Observacao
                       ,Instrutor
                    from Estudo where Cod_Estudo = @Cod_Estudo", new { Cod_Estudo = Cod_Estudo }).FirstOrDefault();
        }
        
        public static List<Estudo> ListByPresenca(int Cod_Presenca, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Estudo>(
                    @"select
                        e.Cod_Estudo
                       ,e.Cod_Presenca 
                       ,e.Cod_Tipo 
                       ,e.Numero 
                       ,e.Observacao 
                       ,e.Instrutor 
                       ,t.Nome as Tipo
                       ,u.Nome as Nome_Instrutor
                    from Estudo e
                    inner join TipoEstudo t on t.Cod_Tipo = e.Cod_Tipo
                    inner join Usuario u on u.Cod_Usuario = e.Instrutor
                    where Cod_Presenca=@Cod_Presenca", new { Cod_Presenca }).ToList();
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Estudo (
                        Cod_Presenca,
                        Cod_Tipo,
                        Numero,
                        Observacao,
                        Instrutor
                    ) {0} values (
                        @Cod_Presenca,
                        @Cod_Tipo,
                        @Numero,
                        @Observacao,
                        @Instrutor
                    ) {1}", "Cod_Estudo"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Estudo set 
                        Cod_Presenca=@Cod_Presenca, 
                        Cod_Tipo=@Cod_Tipo, 
                        Numero=@Numero, 
                        Observacao=@Observacao, 
                        Instrutor=@Instrutor 
                    where Cod_Estudo = @Cod_Estudo", this);
        }
        
        public void Save(Context cx = null)
        {
            if(this.Cod_Estudo == 0)
                this.Cod_Estudo = Insert(cx);
            else
                Update(cx);        
        }
        
        public static void Delete(int Cod_Estudo, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Estudo where Cod_Estudo = @Cod_Estudo", new { Cod_Estudo = Cod_Estudo });
        }        
    }
}
