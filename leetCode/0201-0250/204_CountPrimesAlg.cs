using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _204_CountPrimesAlg
    {
        public int CountPrimes1(int n)
        {
            if (n < 2)
                return 0;
            int i = 2;
            int j = 0;
            int count = 0;
            bool flag = true;
            while (i < n)
            {
                flag = true;
                j = 2;
                int max = j * j;
                while (j <= max)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                    j += 1;
                }
                if (flag)
                {
                    count++;
                }
                i += 1;
            }
            return count;
        }

        public int CountPrimes2(int n)
        {
            bool[] prime = new bool[n];

            for (int i = 0; i < n; i++)
                prime[i] = true;

            for (int p = 2; p * p < n; p++)
            {
                if (prime[p] == true)
                {
                    for (int i = p * p; i < n; i += p)
                        prime[i] = false;
                }
            }

            int count = 0;
            for (int p = 2; p < n; p++)
            {
                if (prime[p] == true)
                {
                    count++;
                }
            }
            return count;
        }
        public int CountPrimes(int n)
        {
            if (n <= 2)
                return 0;
            bool[] prime = new bool[n];

            for (int i = 0; i < n; i++)
                prime[i] = true;

            int total = n - 2;
            for (int p = 2; p * p < n; p++)
            {
                if (prime[p] == true)
                {
                    for (int i = p * p; i < n; i += p)
                    {
                        if (prime[i])
                        {
                            prime[i] = false;
                            total--;
                        }

                    }

                }
            }

            return total;
        }
    }
}
