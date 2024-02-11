using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1451_1500
{
    public class _1491_AverageSalaryExcludingTheMinimumAndMaximumSalaryAlg
    {
        public double Average(int[] salary)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            double sum = 0;
            foreach (int i in salary)
            {
                sum += i;
                max = Math.Max(max, i);
                min = Math.Min(min, i);
            }
            sum = sum - min - max;
            double avg = Math.Round(sum / (salary.Length - 2), 5);

            return avg;
        }
    }
}
