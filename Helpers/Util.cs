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
    }
}
