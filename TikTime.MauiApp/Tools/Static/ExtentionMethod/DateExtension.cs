using System.Globalization;

namespace TikTime.MauiApp.Tools.Static.ExtentionMethod
{
    public static class DateExtension
    {
        public static string GetTimeAgo(this DateTime dateTime)
        {
            var timeSpan = DateTime.Now - dateTime;

            if (timeSpan.TotalSeconds < 60)
                return "چند لحظه پیش";
            if (timeSpan.TotalMinutes < 60)
                return $"{(int)timeSpan.TotalMinutes} دقیقه پیش";
            if (timeSpan.TotalHours < 24)
                return $"{(int)timeSpan.TotalHours} ساعت پیش";
            if (timeSpan.TotalDays < 7)
                return $"{(int)timeSpan.TotalDays} روز پیش";
            if (timeSpan.TotalDays < 30)
                return $"{(int)(timeSpan.TotalDays / 7)} هفته پیش";
            if (timeSpan.TotalDays < 365)
                return $"{(int)(timeSpan.TotalDays / 30)} ماه پیش";

            return $"{(int)(timeSpan.TotalDays / 365)} سال پیش";
        }
        public static string ToShamsi(this DateTime date)
        {
            var prCalender = new PersianCalendar();
            return prCalender.GetYear(date).ToString("00") + "/"
                + prCalender.GetMonth(date).ToString("00") + "/" + prCalender.GetDayOfMonth(date).ToString("00");
        }
        public static string ToShamsi(this DateTime? date)
        {
            var prCalender = new PersianCalendar();
            return prCalender.GetYear(date.Value).ToString("00") + "/"
                + prCalender.GetMonth(date.Value).ToString("00") + "/" + prCalender.GetDayOfMonth(date.Value).ToString("00");
        }

        public static int DayToShamsi(this DateTime date)
        {
            var prCalender = new PersianCalendar();
            return prCalender.GetDayOfMonth(date);
        }
        public static int MonthToShamsi(this DateTime date)
        {
            var prCalender = new PersianCalendar();
            return prCalender.GetMonth(date);
        }
        public static int YearToShamsi(this DateTime date)
        {
            var prCalender = new PersianCalendar();
            return prCalender.GetYear(date);
        }
        public static DateTime ToMiladi(this string persianDate)
        {
            string[] persianDateText = persianDate.Split('/');

            PersianCalendar persianCalendar = new PersianCalendar();
            var convertedDateResult = new DateTime(int.Parse(persianDateText[0]), int.Parse(persianDateText[1]), int.Parse(persianDateText[2]), persianCalendar);
            return convertedDateResult;
        }

    }
}
