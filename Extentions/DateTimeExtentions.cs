using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using GregorianCalendar = Java.Util.GregorianCalendar;

namespace ScoutingModels.Extentions
{
    public static class DateTimeExtentions
    {
        public static int GetWeekNumber(this DateTime date)
        {
            return GetWeekNumber(date, CultureInfo.CurrentCulture);
        }

        public static int GetWeekNumber(this DateTime date, CultureInfo culture)
        {
            return culture.Calendar.GetWeekOfYear(date,
                culture.DateTimeFormat.CalendarWeekRule,
                culture.DateTimeFormat.FirstDayOfWeek);
        }

        public static int GetWeekNumberOfMonth(this DateTime date)
        {
            return GetWeekNumberOfMonth(date, CultureInfo.CurrentCulture);
        }

        public static int GetWeekNumberOfMonth(this DateTime date, CultureInfo culture)
        {
            return date.GetWeekNumber(culture)
                - new DateTime(date.Year, date.Month, 0).
            GetWeekNumber(culture);
        }
    }
}
