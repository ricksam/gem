using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class Presenca : BaseEntity<Presenca> 
    {
        public int Cod_Presenca { get; set; }
        public int Cod_Usuario { get; set; }
        public DateTime Data { get; set; }
        public int Instrutor { get; set; }
        
        public static Presenca Find(int Cod_Presenca, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Presenca>(
                    @"select 
                        Cod_Presenca
                       ,Cod_Usuario
                       ,Data
                       ,Instrutor
                    from Presenca where Cod_Presenca = @Cod_Presenca", new { Cod_Presenca = Cod_Presenca }).FirstOrDefault();
        }
        
        public static List<Presenca> List(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Presenca>(
                    @"select
                        Cod_Presenca
                       ,Cod_Usuario 
                       ,Data 
                       ,Instrutor 
                    from Presenca").ToList();
        }
        
        public static List<Presenca> ListInCod_Usuario(int[] Cod_Usuarios, DateTime Data, Context cx = null){
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Presenca>(
                string.Format(
                    @"select
                        Cod_Presenca
                       ,Cod_Usuario 
                       ,Data 
                       ,Instrutor 
                    from Presenca
                    where Cod_Usuario in ({0})
                    and Data = @Data",
                    String.Join(",", Cod_Usuarios)),
                    new { Data = Data.ToString("yyyy-MM-dd") }).ToList();
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Presenca (
                        Cod_Usuario,
                        Data,
                        Instrutor
                    ) {0} values (
                        @Cod_Usuario,
                        @Data,
                        @Instrutor
                    ) {1}", "Cod_Presenca"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Presenca set 
                        Cod_Usuario=@Cod_Usuario, 
                        Data=@Data, 
                        Instrutor=@Instrutor 
                    where Cod_Presenca = @Cod_Presenca", this);
        }
        
        public void Save(Context cx = null)
        {
            if(this.Cod_Presenca == 0)
                this.Cod_Presenca = Insert(cx);
            else
                Update(cx);        
        }
        
        public static void Delete(int Cod_Presenca, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Presenca where Cod_Presenca = @Cod_Presenca", new { Cod_Presenca = Cod_Presenca });
        }        
    }
}
