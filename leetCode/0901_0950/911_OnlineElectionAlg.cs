using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _911_OnlineElectionAlg
    {
        public class TopVotedCandidate
        {

            int[] personsArr;
            int[] timesArr;
            int[] ansArr;
            public TopVotedCandidate(int[] persons, int[] times)
            {
                personsArr = persons;
                timesArr = times;
                ansArr = new int[persons.Length];
                Array.Fill(ansArr, -1);
                int ans = -1;
                int val = int.MinValue;
                Dictionary<int, int> dict = new Dictionary<int, int>();
                for (int i = 0; i < persons.Length; i++)
                {
                    if (dict.ContainsKey(personsArr[i]))
                    {
                        dict[personsArr[i]]++;
                    }
                    else
                    {
                        dict.Add(personsArr[i], 1);
                    }
                    if (dict[personsArr[i]] >= val)
                    {
                        ans = i;
                        val = dict[personsArr[i]];
                    }
                    ansArr[i] = i;
                }

            }

            public int Q(int t)
            {
              
                int idx = RightBinarySearch(t);
                return personsArr[ansArr[idx]];
            }

            private int RightBinarySearch(int target)
            {
                int left = 0;
                int right = timesArr.Length - 1;
                int ans = 0;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (timesArr[mid] <= target)
                    {
                        ans = mid;
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                return ans;
            }
        }

    }
}
