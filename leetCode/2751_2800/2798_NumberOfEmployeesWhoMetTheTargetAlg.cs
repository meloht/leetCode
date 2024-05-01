using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2751_2800
{
    public class _2798_NumberOfEmployeesWhoMetTheTargetAlg
    {
        public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            int num = hours.Count(p => p >= target);
            return num;
        }
    }
}
