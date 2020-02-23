using System;
using System.Collections.Generic;
using System.Linq;

namespace GEM.Models
{
    public class EscalaBuilder
    {
        public string Titulo = "";
        public int Tentativas = 0;
        public List<DayOfWeek> dayOfWeeks = new List<DayOfWeek>();
        List<DiaEscala> diasEscala = new List<DiaEscala>();
        public DateTime StartDate{ get; set; }
        public DateTime EndDate{ get; set; }
        private int IndexNome = -1;
        public string [] Nomes{ get; set; }
        public bool Dupla{ get; set; }
        public void AddDay(DiaEscala dia)
        {
            diasEscala.Add(dia);
        }

        public void Initialize(){
            DateTime dtRef = StartDate;
            while (dtRef <= EndDate)
            {
                if (dayOfWeeks.Contains(dtRef.DayOfWeek))
                {
                    AddDay(new DiaEscala() { Data = dtRef });
                }
                dtRef = dtRef.AddDays(1);
            }
        }

        public DateTime GetFirstDate(){
            if(diasEscala.Count==0){
                return DateTime.Now.Date;
            }else{
                return diasEscala[0].Data;
            }
        }

        public DateTime GetNextDate(DateTime data){
            DateTime dtRef = data.AddDays(1);
            while (dtRef <= EndDate)
            {
                if (dayOfWeeks.Contains(dtRef.DayOfWeek))
                {
                    break;
                }
                dtRef = dtRef.AddDays(1);
            }
            return dtRef;
        }

        public DateTime GetNextDateByWeek(DateTime data, DayOfWeek week){
            DateTime dtRef = data.AddDays(1);
            while (dtRef <= EndDate)
            {
                if (dtRef.DayOfWeek == week)
                {
                    break;
                }
                dtRef = dtRef.AddDays(1);
            }
            return dtRef;
        }

        public DayOfWeek GetNextDayOfWeek(DayOfWeek current){
            List<DayOfWeek> days = new List<DayOfWeek>();
            days.AddRange(dayOfWeeks);
            days.AddRange(dayOfWeeks);

            bool obter = false;
            foreach (var item in days)
            {
                if(item == current){
                    obter=true;
                    continue;
                }
                else if(obter){
                    return item;
                }
            }
            return current;
        }

        public List<DayOfWeek> GetLoopOrder(DateTime data){
            List<DayOfWeek> weeks = new List<DayOfWeek>();
            weeks.Add(data.DayOfWeek);
            
            DayOfWeek week = data.DayOfWeek;

            while(weeks.Count <= 7){
                week = GetNextDayOfWeek(week);
                if(weeks.Contains(week)){
                    break;
                }else{
                    weeks.Add(week);
                }
            }
            return weeks;
        }

        public string GetNextNome(){
            IndexNome++;
            if(IndexNome >= Nomes.Length){
                IndexNome = 0;
            }

            return Nomes[IndexNome];
        }

        public void AddConjunto(DateTime dia){
            if(Dupla){
                string nome1 = GetNextNome();
                string nome2 = GetNextNome(); 
                AddConjunto(dia, new Conjunto(){
                    MeiaHora=nome1,
                    Culto=nome2
                });
            }
            else
            {
                string nome = GetNextNome();
                AddConjunto(dia, new Conjunto(){
                    MeiaHora=nome,
                    Culto=nome
                });
            }
            
        }

        public void AddConjunto(DateTime Dia, Conjunto conjunto)
        {
            foreach (var item in diasEscala)
            {
                if (item.Data == Dia)
                {
                    item.Conjunto = new Conjunto()
                    {
                        Culto = conjunto.Culto,
                        MeiaHora = conjunto.MeiaHora
                    };
                    break;
                }
            }
        }

        /*public void Inverter(DateTime Dia)
        {
            foreach (var item in diasEscala)
            {
                if (item.Data == Dia)
                {
                    item.Conjunto.Inverter();
                    break;
                }
            }
        }

        public List<DateTime> ListaDatas()
        {
            return diasEscala.Select(s => s.Data).ToList();
        }*/

        public List<DiaEscala> ListaEscala()
        {
            return diasEscala;
        }

        /*public bool DatasProximas(int qtde, int tentativa)
        {
            bool Result = false;
            DateTime dtRef = DateTime.MinValue;
            string lastNome = "";

            string log = "";

            qtde = qtde - 1;
            if (tentativa < 100)
            {
                if (qtde > 7)
                {
                    qtde = 7;
                }
            }
            else if (tentativa < 150)
            {
                if (qtde > 3)
                {
                    qtde = 3;
                }
            }
            else if (tentativa < 180)
            {
                if (qtde > 2)
                {
                    qtde = 2;
                }
            }
            else
            {
                qtde = 1;
            }

            var listaPronta = diasEscala.OrderBy(o => o.Conjunto.MeiaHora).ThenBy(o => o.Data).ToList();
            listaPronta.ForEach(f =>
                {
                    if (lastNome != f.Conjunto.MeiaHora)
                    {
                        dtRef = DateTime.MinValue;
                    }
                    lastNome = f.Conjunto.MeiaHora;
                    double totalDays = Math.Abs(f.Data.Subtract(dtRef).TotalDays);
                    Result |= ((int)totalDays < qtde);
                    dtRef = f.Data;
                    log += f + " " + Result + "\r\n";
                });



            return Result;
        }*/

        public EscalaMes BuildMes(int Mes){
            EscalaMes escalaMes = new EscalaMes();

            escalaMes.DayOfWeeks = dayOfWeeks;
            escalaMes.DiasEscala = ListaEscala().Where(q => q.Data.Month == Mes).ToList();

            escalaMes.NomeMes = escalaMes.DiasEscala.FirstOrDefault().Data.ToString("MMMM");

            foreach (var item in escalaMes.DayOfWeeks)
            {
                if (item != escalaMes.DiasEscala.FirstOrDefault().Data.DayOfWeek)
                {
                    escalaMes.OffSet++;
                }
                else
                {
                    break;
                }
            }

            return escalaMes;
        }
    }
    
    public class EscalaMes
    {
        public string NomeMes = "";
        public int OffSet = 0;
        public List<DayOfWeek> DayOfWeeks = new List<DayOfWeek>();
        public List<DiaEscala> DiasEscala = new List<DiaEscala>();
    }

    

    public class DiaEscala
    {
        public DateTime Data { get; set; }
        public Conjunto Conjunto { get; set; }
        public override string ToString()
        {
            return string.Format("{0}: {1} - {2}", Data.ToString(), Conjunto.MeiaHora, Conjunto.Culto);
        }
    }

    public class Conjunto
    {
        public string MeiaHora { get; set; }
        public string Culto { get; set; }
        public string IdMeiaHora{ get{ return GEM.Helpers.Encryption.md5(MeiaHora); } }
        public string IdCulto{ get{ return GEM.Helpers.Encryption.md5(Culto); } }
        public void Inverter()
        {
            string s = this.MeiaHora;
            this.MeiaHora = this.Culto;
            this.Culto = s;
        }
    }    
}