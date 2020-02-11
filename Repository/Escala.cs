using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class Escala : BaseEntity<Escala> 
    {
        public int Cod_Escala { get; set; }
        public string Nome { get; set; }
        public int Cod_Usuario { get; set; }
        public string Usuarios { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public string Dias { get; set; }
        public bool Dupla { get; set; }
        public bool DiaSequencial { get; set; }
        
        public static Escala Find(int Cod_Escala, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Escala>(
                    @"select 
                        Cod_Escala
                       ,Cod_Usuario
                       ,Nome
                       ,Usuarios
                       ,Inicio
                       ,Fim
                       ,Dias
                       ,Dupla
                       ,DiaSequencial
                    from Escala where Cod_Escala = @Cod_Escala", new { Cod_Escala = Cod_Escala }).FirstOrDefault();
        }
        
        public static List<Escala> List(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Escala>(
                    @"select
                        Cod_Escala
                       ,Cod_Usuario
                       ,Nome 
                       ,Usuarios 
                       ,Inicio 
                       ,Fim 
                       ,Dias 
                       ,Dupla 
                       ,DiaSequencial 
                    from Escala").ToList();
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Escala (
                        Cod_Usuario,
                        Nome,
                        Usuarios,
                        Inicio,
                        Fim,
                        Dias,
                        Dupla,
                        DiaSequencial
                    ) {0} values (
                        @Cod_Usuario,
                        @Nome,
                        @Usuarios,
                        @Inicio,
                        @Fim,
                        @Dias,
                        @Dupla,
                        @DiaSequencial
                    ) {1}", "Cod_Escala"), this).Single();
        }
        
        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Escala set 
                        Cod_Usuario=@Cod_Usuario, 
                        Nome=@Nome,
                        Usuarios=@Usuarios, 
                        Inicio=@Inicio, 
                        Fim=@Fim, 
                        Dias=@Dias, 
                        Dupla=@Dupla, 
                        DiaSequencial=@DiaSequencial 
                    where Cod_Escala = @Cod_Escala", this);
        }
        
        public void Save(Context cx = null)
        {
            if(this.Cod_Escala == 0)
                this.Cod_Escala = Insert(cx);
            else
                Update(cx);        
        }
        
        public static void Delete(int Cod_Escala, int Cod_Comum, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(@"delete from Escala where Cod_Escala = @Cod_Escala and Cod_Comum = @Cod_Comum", new { Cod_Escala, Cod_Comum });
        }        
    }
}
