using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nLibary
{
    public class cDateTime
	{
        public static DateTime daetetimeToLocal(DateTime dt1, CultureInfo ci)
        {
            if (ci.IetfLanguageTag == "th-TH")
            {
                dt1.AddYears(10);
            }

            return dt1;
        }
        public static string dateDiffStr(DateTime dt1, DateTime dt2)
        {
            //years
            TimeSpan diff = dt2.Subtract(dt1);
            int Years = diff.Days / 366;
            DateTime workingDate = dt1.AddYears(Years);

            while (workingDate.AddYears(1) <= dt2)
            {
                workingDate = workingDate.AddYears(1);
                Years++;
            }

            //months
            diff = dt2.Subtract(dt1);
            int Months = diff.Days / 31;
            workingDate = workingDate.AddMonths(Months);

            while (workingDate.AddMonths(1) <= dt2)
            {
                workingDate = workingDate.AddMonths(1);
                Months++;
            }

            //weeks and days
            diff = dt2 - workingDate;
            int Weeks = diff.Days / 7; //weeks always have 7 days
            int Days = diff.Days % 7;

            string res = "";
            if (Years > 0)
            {
                res += Years + " ปี,";
            }
            if (Months > 0)
            {
                res += Months + " เดือน,";
            }
            if (Days > 0)
            {
                res += Days + " วัน,";
            }
            res = res.Remove(res.Length - 1);
            return res.ToString();
        }
        public static string dateDiff(DateTime dt1, DateTime dt2)
        {
            //years
            TimeSpan diff = dt2.Subtract(dt1);
            int Years = diff.Days / 366;
            DateTime workingDate = dt1.AddYears(Years);

            while (workingDate.AddYears(1) <= dt2)
            {
                workingDate = workingDate.AddYears(1);
                Years++;
            }

            //months
            diff = dt2.Subtract(dt1);
            int Months = diff.Days / 31;
            workingDate = workingDate.AddMonths(Months);

            while (workingDate.AddMonths(1) <= dt2)
            {
                workingDate = workingDate.AddMonths(1);
                Months++;
            }

            //weeks and days
            diff = dt2 - workingDate;
            int Weeks = diff.Days / 7; //weeks always have 7 days
            int Days = diff.Days % 7;

            var res = String.Format("{0}:{1}:{2}", Years, Months, Days);

            return res.ToString();
        }
        public static string timeDiff(DateTime dt1, DateTime dt2)
        {
            //var diff = dt2.Subtract(dt1);
            TimeSpan diff = dt2.Subtract(dt1);
            var res = String.Format("{0}:{1}:{2}", diff.Hours, diff.Minutes, diff.Seconds);

            return res.ToString();
        }
        public static string getDateTimeWithMilliSecondForSql()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.fff", us);

            return temp;
        }
        public static string getDateTimeWithOutMilliSecondForShow()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", us);

            return temp;
        }
        public static string getDateTimeForShow()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.000", us);

            return temp;
        }
        public static string getDateTimeForSql()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.000", us);

            return temp;
        }
        public static string getDateForShow()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.ToString("dd/MM/yyyy", us);

            return temp;
        }
        public static string getDateForShowUS()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.ToString("dd/MM/yyyy", us);

            return temp;

        }
        public static string getDateForShowTH()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("th-TH");

            string temp = DateTime.Now.ToString("dd/MM/yyyy", us);
            return temp;

        }
        public static string getDateForShowLong()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("th-TH");

            string temp = DateTime.Now.ToString("วัน dddd ที่ dd MMMMM yyyy", us);

            return temp;
        }
        public static string getDateForSql()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.ToString("yyyy.MM.dd", us);

            return temp;
        }
        public static string getDateForSql(double days)
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.AddDays(days).ToString("yyyy.MM.dd", us);

            return temp;
        }
        public static string getDateForSql(int year)
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.AddYears(year).ToString("yyyy.MM.dd", us);

            return temp;
        }
        public static string getDateTimeWithYearOnly()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.ToString("yyyy", us);

            return temp;
        }
        public static string getDateTimeWithMonthOnly()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.ToString("MM", us);

            return temp;
        }
        public static string getDateTimeWithMonthOnly(int month)
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.AddMonths(month).ToString("MM", us);

            return temp;
        }
        public static string getDateTimeWithDayOnly()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.ToString("dd", us);

            return temp;
        }
        public static string getDateTimeWithHourOnly()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.ToString("HH", us);

            return temp;
        }
        public static string getDateTimeWithMinutesOnly()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.ToString("mm", us);

            return temp;
        }
        public static string getDateTimeWithSecondsOnly()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            string temp = DateTime.Now.ToString("ss", us);

            return temp;
        }
        public static string getDateWithLastDayInMonthForSql(int atYear, int atMonth)
        {
            string result = "";

            var lastDayOfMonth = DateTime.DaysInMonth(atYear, atMonth);

            result = atYear.ToString() + "." + atMonth.ToString() + "." + lastDayOfMonth.ToString();

            return result;
        }
        public static string getDateWithLastDayInMonthForShow(int atYear, int atMonth)
        {
            string result = "";

            var lastDayOfMonth = DateTime.DaysInMonth(atYear, atMonth);

            result = lastDayOfMonth.ToString() + "/" + atMonth.ToString() + "/" + atYear.ToString();

            return result;
        }
        public static string getDateWithLastDayInNextMonthForSql(int atYear, int atMonth)
        {
            string result = "";



            return result;
        }
        public static string getDateWithLastDayInNextYearForSql(int atYear, int atMonth, int nextYear)
        {
            string result = "";

            DateTime firstOfNextYear = new DateTime(atYear, atMonth, 1).AddYears(nextYear);

            var lastDayOfMonth = DateTime.DaysInMonth(firstOfNextYear.Year, firstOfNextYear.Month);

            result = firstOfNextYear.Year.ToString() + "." + firstOfNextYear.Month.ToString() + "." + lastDayOfMonth.ToString();

            return result;
        }
        public static string getDateWithLastDayInNextYearForShow(int atYear, int atMonth, int nextYear)
        {
            string result = "";

            DateTime firstOfNextYear = new DateTime(atYear, atMonth, 1).AddYears(nextYear);

            var lastDayOfMonth = DateTime.DaysInMonth(firstOfNextYear.Year, firstOfNextYear.Month);

            result = lastDayOfMonth.ToString() + "/" + firstOfNextYear.Month.ToString() + "/" + firstOfNextYear.Year.ToString();

            return result;
        }
        public static int getCurrentYear()
        {
            return DateTime.Now.Year;
        }
        public static int getCurrentMonth()
        {
            return DateTime.Now.Month;
        }
        public static int getYearFromDatatimeShow(string datetime)
        {
            string[] arr = datetime.Split('/');
            return int.Parse(arr[2]);
        }
        public static int getMonthFromDatatimeShow(string datetime)
        {
            string[] arr = datetime.Split('/');
            return int.Parse(arr[1]);
        }
        public static int getDayFromDatatimeShow(string datetime)
        {
            string[] arr = datetime.Split('/');
            return int.Parse(arr[0]);
        }
        public static string getDatatimeForSql(string datetime)
        {
            string[] arr = datetime.Split('/');
            return (arr[2] + "." + arr[1] + "." + arr[0]);
        }
        public static string GetDateTimeForBackup()
        {
            string result = "";

            //DateTime dt = DateTime.Now;

            //result = dt.ToString("yyMMdd") + "_" + dt.ToString("hhmmss");
            result = DateTime.Now.ToString("yyMMdd_HHmmss");
            return result;
        }
    }
}
