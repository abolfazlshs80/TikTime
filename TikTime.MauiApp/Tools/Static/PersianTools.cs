using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTime.MauiApp.Tools.Static
{
    public class PersianTools
    {
        public static string GetPersianMonthName(int month)
        {
            string[] persianMonths =
            {
                "فروردین",
                "اردیبهشت",
                "خرداد",
                "تیر",
                "مرداد",
                "شهریور",
                "مهر",
                "آبان",
                "آذر",
                "دی",
                "بهمن",
                "اسفند"
            };

            if (month >= 1 && month <= 12)
                return persianMonths[month - 1];

            return "ماه نامعتبر";
        }

    }
}
