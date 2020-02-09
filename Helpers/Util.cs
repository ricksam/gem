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
    }
}
