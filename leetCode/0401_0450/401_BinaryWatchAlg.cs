using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _401_BinaryWatchAlg
    {
        public IList<string> ReadBinaryWatch1(int turnedOn)
        {
            List<string> res = new List<string>();
            if (turnedOn > 8)
            {
                return res;
            }

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    int n1 = GetCount1(i);
                    int n2 = GetCount1(j);
                    if (n1 + n2 == turnedOn)
                    {
                        res.Add($"{i}:{j.ToString().PadLeft(2, '0')}");
                    }
                }
            }
            return res;
        }
        private int GetCount1(int num)
        {
            int count = 0;
            while (num != 0)
            {
                num = num & (num - 1);
                count++;
            }
            return count;
        }

        public IList<string> ReadBinaryWatch(int turnedOn)
        {
            List<string> res = new List<string>();
            if (turnedOn > 8)
            {
                return res;
            }

            int[] times = new int[10];
            Dfs(times, 0, turnedOn, res);

            return res;
        }


        private void Dfs(int[] times, int pos, int count, List<string> res)
        {
            if (count == 0)
            {
                int hour = times[0] + 2 * times[1] + times[2] * 4 + times[3] * 8;
                int minute = times[4] + times[5] * 2 + times[6] * 4 + times[7] * 8 + times[8] * 16 + times[9] * 32;
                if (hour < 12 && minute < 60)
                {
                    res.Add($"{hour}:{minute.ToString().PadLeft(2, '0')}");
                }
                return;
            }


            for (int i = pos; i <= 10 - count; i++)
            {
                times[i]++;
                Dfs(times, i + 1, count - 1, res);
                times[i]--;
            }
        }
    }
}
