using System;

namespace EnergyUsage.utils
{
    class TimeUtils
    {
        public static bool isSummerTime(object sender, EventArgs e)
        {
            //workOutDates(2, 2023);

            //DateTime dateToCheck = dtTmPicker.Value;
            //DateTime startDate = DateTime.Parse(lbl_date_to_change_to_BST.Text);
            //DateTime endDate = DateTime.Parse(lbl_date_to_change_to_GMT.Text);

            //return (dateToCheck >= startDate && dateToCheck < endDate); //true = summer GMT + 1hr

            return true;
        }

        private static void workOutDates(int months, int year)
        {

            bool flag = false;
            
            int month;
            DateTime date;
            string answer;

            //for (int i = 1; i <= months; i++)
            //{
            //    if (flag) //if we want all the months or just when we change to and from BST
            //    {
            //        month = (months == 2) ? 10 : i;
            //    }
            //    else
            //    {
            //        month = (months == 2) ? 3 : i;
            //    }

            //    date = new DateTime(year, month, DateTime.DaysInMonth(year, month), System.Globalization.CultureInfo.CurrentCulture.Calendar);

            //    int daysOffset = date.DayOfWeek - DayOfWeek.Sunday;
            //    if (daysOffset < 0) daysOffset += 7; // if the code is negative, we need to normalize them

            //    answer = date.AddDays(-daysOffset).ToLongDateString();

            //    if ((months == 2) && (flag))
            //    {
            //        lbl_date_to_change_to_GMT.Text = answer;
            //    }
            //    else if ((months == 2) && (!flag))
            //    {
            //        lbl_date_to_change_to_BST.Text = answer;
            //    }

            //    flag = true; //needed for October dates when months == 2.
            //}
        }













    }
}
