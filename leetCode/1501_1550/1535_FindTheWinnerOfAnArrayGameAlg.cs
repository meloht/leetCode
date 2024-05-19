using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1501_1550
{
    public class _1535_FindTheWinnerOfAnArrayGameAlg
    {
        public int GetWinner1(int[] arr, int k)
        {
            if (k >= arr.Length - 1)
            {
                int max = arr.Max();
                return max;
            }

            var list = arr.ToList();

            int count = k;

            while (count > 0)
            {
                if (list[0] > list[1])
                {
                    count--;
                    int num = list[1];
                    list.RemoveAt(1);
                    list.Add(num);
                }
                else
                {

                    count = k - 1;
                    int num = list[0];
                    list.RemoveAt(0);
                    list.Add(num);

                }
                if (count == 0)
                {
                    return list[0];
                }
            }

            return 0;
        }

        public int GetWinner(int[] arr, int k)
        {
            int prev = Math.Max(arr[0], arr[1]);
            if (k == 1)
            {
                return prev;
            }
            int consecutive = 1;
            int maxNum = prev;
            int length = arr.Length;
            for (int i = 2; i < length; i++)
            {
                int curr = arr[i];
                if (prev > curr)
                {
                    consecutive++;
                    if (consecutive == k)
                    {
                        return prev;
                    }
                }
                else
                {
                    prev = curr;
                    consecutive = 1;
                }
                maxNum = Math.Max(maxNum, curr);
            }
            return maxNum;

        }
    }
}
