using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;
using GEM.Helpers;
using GEM.Models;

namespace GEM.Repository
{
    public class Escala : BaseEntity<Escala> 
    {
        public int Cod_Escala { get; set; }
        public string Nome { get; set; }
        public int Cod_Usuario { get; set; }
        public int Cod_Comum { get; set; }
        public string Usuarios { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public string Dias { get; set; }
        public bool Dupla { get; set; }
        public bool DiaSequencial { get; set; }

        //External
        public string Instrutor { get; set; }

        public Semana GetDiasSemana(){
            try{
                return JSON.Deserialize<Semana>(Dias);
            }catch{}
            return new Semana();
        }

        public List<DayOfWeek> ListDayOfWeek(){
            Semana semana = GetDiasSemana();
            List<DayOfWeek> list = new List<DayOfWeek>();
            if (semana.Dom)
            {
                list.Add(DayOfWeek.Sunday);
            }

            if (semana.Seg)
            {
                list.Add(DayOfWeek.Monday);
            }

            if (semana.Ter)
            {
                list.Add(DayOfWeek.Tuesday);
            }

            if (semana.Qua)
            {
                list.Add(DayOfWeek.Wednesday);
            }

            if (semana.Qui)
            {
                list.Add(DayOfWeek.Thursday);
            }

            if (semana.Sex)
            {
                list.Add(DayOfWeek.Friday);
            }

            if (semana.Sab)
            {
                list.Add(DayOfWeek.Saturday);
            }

            return list;
        }

        public void SetDiasSemana(Semana semana){
            Dias = JSON.Serialize(semana);
        }

        public string[] GetUsuarios(){
            try{
                return JSON.Deserialize<string[]>(Usuarios);
            }catch{}
            return new string[]{};
        }

        public void SetUsuarios(string[] usuarios){
            Usuarios = JSON.Serialize(usuarios);
        }
        
        public static Escala Find(int Cod_Escala, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Escala>(
                    @"select 
                        Cod_Escala
                       ,Cod_Usuario
                       ,Cod_Comum
                       ,Nome
                       ,Usuarios
                       ,Inicio
                       ,Fim
                       ,Dias
                       ,Dupla
                       ,DiaSequencial
                    from Escala where Cod_Escala = @Cod_Escala", new { Cod_Escala = Cod_Escala }).FirstOrDefault();
        }
        
        public static List<Escala> List(int Cod_Comum, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<Escala>(
                    @"select
                        e.Cod_Escala
                       ,e.Cod_Usuario
                       ,e.Cod_Comum
                       ,e.Nome 
                       ,e.Usuarios 
                       ,e.Inicio 
                       ,e.Fim 
                       ,e.Dias 
                       ,e.Dupla 
                       ,e.DiaSequencial 
                       ,u.Nome as Instrutor
                    from Escala e
                    inner join Usuario u on u.Cod_Usuario = e.Cod_Usuario
                    where e.Cod_Comum = @Cod_Comum", new { Cod_Comum }).ToList();
        }
        
        private int Insert(Context cx = null) 
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Escala (
                        Cod_Usuario,
                        Cod_Comum,
                        Nome,
                        Usuarios,
                        Inicio,
                        Fim,
                        Dias,
                        Dupla,
                        DiaSequencial
                    ) {0} values (
                        @Cod_Usuario,
                        @Cod_Comum,
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
                        Cod_Comum=@Cod_Comum,
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
