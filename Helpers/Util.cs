using System;

namespace GEM.Helpers{
    public static class Util{
        public static DateTime BrazilianDatetimeNow()
        {
            var info = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            DateTimeOffset localServerTime = DateTimeOffset.Now;
            DateTimeOffset brazilTime = TimeZoneInfo.ConvertTime(localServerTime, info);
            return Convert.ToDateTime(brazilTime.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        public static string ShortName(string FullName){
            if(string.IsNullOrEmpty(FullName)){
                return "";
            }
            
            string[] split = FullName.Split(" ");
            
            if(split.Length == 2){
                return FullName;
            }

            string name = "";

            if(split.Length > 0){
                name += split[0];
            }

            if(split.Length > 1){
                for (int i = 1; i < split.Length-1; i++)
                {
                    if(split[i].Length > 3){
                        name += " " + split[i];
                        break;
                    }
                }
            }
            return name;
        }

        public static string NomeEscala(int Numero){
            switch (Numero)
            {
                case 1 : { return "Dó"; }
                case 2 : { return "Ré Bemol"; }
                case 3 : { return "Ré"; }
                case 4 : { return "Mi Bemol"; }
                case 5 : { return "Mi"; }
                case 6 : { return "Fá"; }
                case 7 : { return "Sol Bemol"; }
                case 8 : { return "Sol"; }
                case 9 : { return "La Bemol"; }
                case 10 : { return "Lá"; }
                case 11 : { return "Si Bemol"; }
                case 12 : { return "Si"; }
                default:{ return ""; }
            }
        }

        public static string NomeOperacao(char c){
            if(c=='C'){ return "Cadastrou"; }
            if(c=='R'){ return "Visualizou"; }
            if(c=='U'){ return "Alterou"; }
            if(c=='D'){ return "Apagou"; }
            return "";

        }
    }
}
