using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._400
{
    public class Alg_400_03
    {
        public string ClearStars(string s)
        {

            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    num++;
                }
            }
            PriorityQueue<int, int[]> queue = new PriorityQueue<int, int[]>(Comparer<int[]>.Create(Compara));
            char[] arr = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    if (num > 0)
                    {
                        int index = queue.Dequeue();
                        arr[index] = '-';

                    }

                    arr[i] = '-';
                    num--;
                }
                else
                {
                    queue.Enqueue(i, [s[i] - 'a', i]);
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (var item in arr)
            {
                if (item != '-')
                {
                    sb.Append(item);
                }
            }
            return sb.ToString();
        }

        public int Compara(int[] x, int[] y)
        {
            int res = x[0].CompareTo(y[0]);
            if (res == 0)
            {
                return y[1].CompareTo(x[1]);
            }
            return res;
        }

    }
}
