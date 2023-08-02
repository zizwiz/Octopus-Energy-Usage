using System;

namespace EnergyUsage.utils
{


    class TimeUtils
    {
        public static (bool timeFrom, bool timeTo) isSummerTime(int yearFrom, DateTime myDateFrom, int yearTo, DateTime myDateTo)
        {
           // Form1 frm = (Form1)myParentForm;

            int month = 3;
            int year = yearFrom;
            DateTime date;
            string answer;
            DateTime startDate = myDateFrom;
            DateTime endDate = myDateTo;

            for (int i = 1; i <= 2; i++)
            {
                date = new DateTime(year, month, DateTime.DaysInMonth(year, month), System.Globalization.CultureInfo.CurrentCulture.Calendar);

                int daysOffset = date.DayOfWeek - DayOfWeek.Sunday;
                if (daysOffset < 0) daysOffset += 7; // if the code is negative, we need to normalize them

                answer = date.AddDays(-daysOffset).ToLongDateString();

                if (month == 10)
                {
                    endDate = DateTime.Parse(answer); //GMT
                }
                else if (month == 3)
                {
                    startDate = DateTime.Parse(answer); //BST
                }

                month = 10;
                year = yearTo;
            }
            
            return (timeFrom: myDateFrom >= startDate, timeTo: myDateTo < endDate); //true = summer GMT + 1hr
        }

       





    }
}
