using System;

namespace Apteka.Utils
{
    public static class DateTimeExtensions
    {
        public static string ToStrDateTime(this DateTime inParam, string format = "dd.MM.yyyy HH:mm:ss")
        {
            return inParam.ToString(format);
        }

        public static bool IsBetween(this DateTime dt, DateTime start, DateTime end)
        {
            return dt >= start && dt <= end;
        }

        public static string ToMsSqlDate(this DateTime source, int type = 0)
        {
            try
            {
                var res = "";
                switch (type)
                {
                    case -1:
                        res = $"{source:yyyy-MM-dd}";
                        res = "CONVERT(DATETIME, '" + res + "', 102)";
                        break;
                    case 0:
                        res = $"{source:yyyy-MM-dd H:mm:ss}";
                        res = "CONVERT(DATETIME, '" + res + "', 102)";
                        break;
                    case 1:
                        res = $"{source:yyyy-MM-dd}";
                        res = "CONVERT(DATETIME, '" + res + " 00:00:00', 102)";
                        break;
                    case 2:
                        res = $"{source:yyyy-MM-dd}";
                        res = "CONVERT(DATETIME, '" + res + " 23:59:59', 102)";
                        break;
                }

                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}