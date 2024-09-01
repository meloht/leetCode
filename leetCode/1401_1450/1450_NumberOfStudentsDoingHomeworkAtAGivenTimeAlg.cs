using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1401_1450
{
    public class _1450_NumberOfStudentsDoingHomeworkAtAGivenTimeAlg
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int ans = 0;
            for (int i = 0; i < startTime.Length; i++)
            {
                if (queryTime >= startTime[i] && queryTime <= endTime[i])
                {
                    ans++;
                }
            }

            return ans;

        }
    }
}
