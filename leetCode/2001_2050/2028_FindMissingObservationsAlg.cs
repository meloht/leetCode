using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2001_2050
{
    public class _2028_FindMissingObservationsAlg
    {
        public int[] MissingRolls(int[] rolls, int mean, int n)
        {
            int sum = rolls.Sum();
            int count = rolls.Length + n;
            int num = mean * count - sum;
            int num1 = num / n;
            if (num > n * 6 || num <= 0 || num < n)
            {
                return [];
            }

            if (num % n == 0)
            {

                int[] result = new int[n];
                for (int i = 0; i < n; i++)
                {
                    result[i] = num1;
                }
                return result;
            }
            else
            {
                int num2 = num % n;
                int[] result = new int[n];
                for (int i = 0, j = num2; i < n; i++, j--)
                {
                    if (j > 0)
                    {
                        result[i] = num1 + 1;
                    }
                    else
                    {
                        result[i] = num1;
                    }

                }
                return result;
            }

        }
    }
}
