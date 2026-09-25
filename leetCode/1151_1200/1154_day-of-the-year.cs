using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1151_1200
{
    public class _1154_day_of_the_year
    {
        public int DayOfYear(string date)
        {
            string[] arr = date.Split('-');
            int year = int.Parse(arr[0]);
            int month = int.Parse(arr[1]);
            int day = int.Parse(arr[2]);
            int[] days = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
            int num = day;
            for (int i = 0; i < month - 1; i++)
            {
                num += days[i];
                if (i == 1 && ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0))
                {
                    num++;
                }

            }

            return num;
        }
    }
}
