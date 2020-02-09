using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class Instrumento : BaseEntity<Instrumento> 
    {
        public int Cod_Instrumento { get; set; }
        public string Nome { get; set; }
        public string Afinacao { get; set; }
        public string Principal { get; set; }
        public string Alternativa { get; set; }
        public int Cod_Categoria { get; set; }

        //External
        public string Categoria { get; set; }
        
        public static Instrumento Find(int Cod_Instrumento, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Instrumento>(
                    @"select 
                        Cod_Instrumento
                       ,Nome
                       ,Afinacao
                       ,Principal
                       ,Alternativa
                       ,Cod_Categoria
                    from Instrumento where Cod_Instrumento = @Cod_Instrumento", new { Cod_Instrumento = Cod_Instrumento }).FirstOrDefault();
        }
        
        public static List<Instrumento> List(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Instrumento>(
                    @"select
                        i.Cod_Instrumento
                       ,i.Nome 
                       ,i.Afinacao 
                       ,i.Principal 
                       ,i.Alternativa 
                       ,i.Cod_Categoria 
                       ,c.Nome as Categoria
                    from Instrumento i
                    inner join Categoria c on c.Cod_Categoria = i.Cod_Categoria").ToList();
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Instrumento (
                        Nome,
                        Afinacao,
                        Principal,
                        Alternativa,
                        Cod_Categoria
                    ) {0} values (
                        @Nome,
                        @Afinacao,
                        @Principal,
                        @Alternativa,
                        @Cod_Categoria
                    ) {1}", "Cod_Instrumento"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Instrumento set 
                        Nome=@Nome, 
                        Afinacao=@Afinacao, 
                        Principal=@Principal, 
                        Alternativa=@Alternativa, 
                        Cod_Categoria=@Cod_Categoria 
                    where Cod_Instrumento = @Cod_Instrumento", this);
        }
        
        public void Save(Context cx = null)
        {
            if(this.Cod_Instrumento == 0)
                this.Cod_Instrumento = Insert(cx);
            else
                Update(cx);        
        }
        
        public static void Delete(int Cod_Instrumento, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Instrumento where Cod_Instrumento = @Cod_Instrumento", new { Cod_Instrumento = Cod_Instrumento });
        }        
    }
}
