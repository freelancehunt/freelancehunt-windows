using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    class clsTimeConvert
    {
        /// <summary>
        /// преобразование даты из ISO 8601
        /// </summary>
        /// <param name="str9061Time">строка в формате ISO 8601</param>
        /// <returns>локальное время</returns>
        public static DateTime dtFrom8061(string str9061Time)
        {
            try
            {
                string[] data = str9061Time.Split('T');

                string[] date = data[0].Split('-');
                string[] time = data[1].Split(new char[] { ':', '+', '-' });

                bool add = str9061Time.LastIndexOf("+") > -1;

                int year = 3000;
                int month = 1;
                int day = 1;

                int houre = 0;
                int minutes = 0;
                int seconds = 0;

                int zone_1 = 0;
                int zone_2 = 0;

                int temp = 0;

                if (int.TryParse(date[0], out temp)) year = temp;
                if (int.TryParse(date[1], out temp)) month = temp;
                if (int.TryParse(date[2], out temp)) day = temp;

                if (int.TryParse(time[0], out temp)) houre = temp;
                if (int.TryParse(time[1], out temp)) minutes = temp;
                if (int.TryParse(time[2], out temp)) seconds = temp;

                if (int.TryParse(time[3], out temp)) zone_1 = temp;
                if (int.TryParse(time[4], out temp)) zone_2 = temp;

                return new DateTime(year,
                                    month,
                                    day,
                                    houre,
                                    minutes,
                                    seconds)
                                    //.AddHours((add ? 1 : -1) * zone_1)
                                    //.AddMinutes((add ? 1 : -1) * zone_2)
                                    ;
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }
    }
}
