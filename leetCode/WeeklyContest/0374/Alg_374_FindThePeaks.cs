using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest
{
    public class Alg_374_FindThePeaks
    {
        public IList<int> FindPeaks(int[] mountain)
        {
            List<int> peak = new List<int>();


            for (int i = 1; i < mountain.Length - 1; i++)
            {
                int pre = mountain[i - 1];
                int num = mountain[i];
                int next = mountain[i + 1];
                if (num > pre && num > next)
                {
                    peak.Add(i);
                }
            }

            return peak;
        }
    }
}
