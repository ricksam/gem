using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace GEM.Repository
{
    public class Monitor : BaseEntity<Monitor> 
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Cod_Usuario { get; set; }
        public char Operacao { get; set; }
        public string Tabela { get; set; }
        public string Descricao { get; set; }
        public int Cod_Comum { get; set; }

        // External
        public string Usuario { get; set; }
        //public string Comum { get; set; }
        
        public static Monitor Find(int Id, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Monitor>(
                    @"select 
                        Id
                       ,Data
                       ,Cod_Usuario
                       ,Operacao
                       ,Tabela
                       ,Descricao
                       ,Cod_Comum
                    from Monitor where Id = @Id", new { Id = Id }).FirstOrDefault();
        }
        
        public static List<Monitor> List(int Cod_Comum, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Monitor>(
                    @"select
                        top 2000
                        m.Id
                       ,m.Data 
                       ,m.Cod_Usuario 
                       ,m.Operacao 
                       ,m.Tabela 
                       ,m.Descricao 
                       ,m.Cod_Comum 
                       ,u.Nome as Usuario
                    from Monitor m
                    inner join Usuario u on u.Cod_Usuario = m.Cod_Usuario
                    where m.Cod_Comum = @Cod_Comum
                    order by m.Id desc", new { Cod_Comum }).ToList();
        }

        public static List<string> ListTabelas(int Cod_Comum, Context cx = null){
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<string>(
                    @"select 
                       m.Tabela 
                    from Monitor m
                    where m.Cod_Comum = @Cod_Comum
                    group by m.Tabela", new { Cod_Comum }).ToList();
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Monitor (
                        Data,
                        Cod_Usuario,
                        Operacao,
                        Tabela,
                        Descricao,
                        Cod_Comum
                    ) {0} values (
                        @Data,
                        @Cod_Usuario,
                        @Operacao,
                        @Tabela,
                        @Descricao,
                        @Cod_Comum
                    ) {1}", "Id"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Monitor set 
                        Data=@Data, 
                        Cod_Usuario=@Cod_Usuario, 
                        Operacao=@Operacao, 
                        Tabela=@Tabela, 
                        Descricao=@Descricao, 
                        Cod_Comum=@Cod_Comum 
                    where Id = @Id", this);
        }
        
        public void Save(Context cx = null)
        {
            if(this.Id == 0)
                this.Id = Insert(cx);
            else
                Update(cx);        
        }
        
        public static void Delete(int Id, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Monitor where Id = @Id", new { Id = Id });
        }        

        public static void Add<T>(HttpContext context, char Operacao, string Descricao){
            var sessao = GEM.Helpers.UserSession.Get(context);
            if(sessao.UserLogged()){
                Monitor monitor =new Monitor();
                monitor.Data = GEM.Helpers.Util.BrazilianDatetimeNow();
                monitor.Cod_Usuario = sessao.Cod_Usuario();
                monitor.Cod_Comum = sessao.Cod_Comum();
                monitor.Operacao = Operacao;
                monitor.Tabela = typeof(T).ToString().Replace("GEM.Repository.", "");
                monitor.Descricao = !string.IsNullOrEmpty(Descricao) && Descricao.Length > 200 ? Descricao.Substring(0,200) : Descricao;
                monitor.Save();
            }
        }
    }
}
