using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class Estudo : BaseEntity<Estudo> 
    {
        public Estudo(){
            this.Id = Guid.NewGuid().ToString();
        }
        
        public int Cod_Estudo { get; set; }
        public int Cod_Presenca { get; set; }
        public int Cod_Tipo { get; set; }
        public int Numero { get; set; }
        public string Observacao { get; set; }
        public int Instrutor { get; set; }

        /*external*/
        public string Id { get; set; }
        public int Cod_Justificativa { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public string Nome_Instrutor { get; set; }
        public string Nome_Aluno { get; set; }
        public string Controle { get; set; }
        
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
                       ,t.Controle
                    from Estudo e
                    inner join TipoEstudo t on t.Cod_Tipo = e.Cod_Tipo
                    inner join Usuario u on u.Cod_Usuario = e.Instrutor
                    where e.Cod_Presenca=@Cod_Presenca", new { Cod_Presenca }).ToList();
        }

        public static List<Estudo> ListHistoricoAluno(int Cod_Usuario, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Estudo>(
                    @"select
                        e.Cod_Estudo
                       ,e.Cod_Presenca 
                       ,0 as Cod_Justificativa
                       ,e.Cod_Tipo 
                       ,e.Numero 
                       ,e.Observacao 
                       ,e.Instrutor 
                       ,t.Nome as Tipo
                       ,u.Nome as Nome_Instrutor
                       ,t.Controle
                       ,p.Data
                    from Estudo e
                    inner join TipoEstudo t on t.Cod_Tipo = e.Cod_Tipo
                    inner join Presenca p on p.Cod_Presenca = e.Cod_Presenca
                    inner join Usuario u on u.Cod_Usuario = e.Instrutor
                    where p.Cod_Usuario=@Cod_Usuario
                    union all
                    select 
                        0 as Cod_Estudo
                        ,0 as Cod_Presenca
                        ,j.Cod_Justificativa 
                        ,0 as Cod_Tipo 
                        ,0 as Numero 
                        ,j.Justificativa as Observacao 
                        ,j.Instrutor 
                        ,'' as Tipo
                        ,u.Nome as Nome_Instrutor
                        ,'' as Controle
                        ,j.Data
                    from FaltaJustificada j
                    inner join Usuario u on u.Cod_Usuario = j.Instrutor
                    where j.Cod_Usuario=@Cod_Usuario
                    union all
                    select  
                        0 as Cod_Estudo
                        ,p.Cod_Presenca
                        ,0 as Cod_Justificativa 
                        ,0 as Cod_Tipo 
                        ,0 as Numero 
                        ,'Presente' as Observacao 
                        ,p.Instrutor 
                        ,'' as Tipo
                        ,u.Nome as Nome_Instrutor
                        ,'' as Controle
                        ,p.Data
                    from Presenca p
                    inner join Usuario u on u.Cod_Usuario = p.Instrutor 
                    left outer join Estudo e on e.Cod_Presenca = p.Cod_Presenca
                    where p.Cod_Usuario = @Cod_Usuario
                    group by p.Cod_Presenca, p.Instrutor, u.Nome, p.Data
                    having count(e.Cod_Estudo) = 0", new { Cod_Usuario }).ToList();
        }

        public static List<Estudo> ListHistoricoInstrutor(int Cod_Usuario, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Estudo>(
                    @"select
                        e.Cod_Estudo
                       ,e.Cod_Presenca 
                       ,0 as Cod_Justificativa
                       ,e.Cod_Tipo 
                       ,e.Numero 
                       ,e.Observacao 
                       ,e.Instrutor 
                       ,t.Nome as Tipo
                       ,u.Nome as Nome_Aluno
                       ,t.Controle
                       ,p.Data
                    from Estudo e
                    inner join TipoEstudo t on t.Cod_Tipo = e.Cod_Tipo
                    inner join Presenca p on p.Cod_Presenca = e.Cod_Presenca
                    inner join Usuario u on u.Cod_Usuario = p.Cod_Usuario and u.Aluno = 1
                    where e.Instrutor=@Cod_Usuario
                    union all
                    select 
                        0 as Cod_Estudo
                        ,0 as Cod_Presenca
                        ,j.Cod_Justificativa 
                        ,0 as Cod_Tipo 
                        ,0 as Numero 
                        ,j.Justificativa as Observacao 
                        ,j.Instrutor 
                        ,'' as Tipo
                        ,u.Nome as Nome_Aluno
                        ,'' as Controle
                        ,j.Data
                    from FaltaJustificada j
                    inner join Usuario u on u.Cod_Usuario = j.Cod_Usuario and u.Aluno = 1
                    where j.Instrutor=@Cod_Usuario
                    union all
                    select  
                        0 as Cod_Estudo
                        ,p.Cod_Presenca
                        ,0 as Cod_Justificativa 
                        ,0 as Cod_Tipo 
                        ,0 as Numero 
                        ,'Presente' as Observacao 
                        ,p.Instrutor 
                        ,'' as Tipo
                        ,u.Nome as Nome_Aluno
                        ,'' as Controle
                        ,p.Data
                    from Presenca p
                    inner join Usuario u on u.Cod_Usuario = p.Cod_Usuario and u.Aluno = 1
                    left outer join Estudo e on e.Cod_Presenca = p.Cod_Presenca
                    where p.Instrutor = @Cod_Usuario
                    group by p.Cod_Presenca, p.Instrutor, u.Nome, p.Data
                    having count(e.Cod_Estudo) = 0", new { Cod_Usuario }).ToList();
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
        
        public static void Delete(int Cod_Estudo, int Cod_Presenca, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Estudo where Cod_Estudo = @Cod_Estudo and Cod_Presenca = @Cod_Presenca", new { Cod_Estudo, Cod_Presenca });
        }        
    }
}
