using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _43_MultiplyStringsAlg
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            int countA = 0;
            string sum = null;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int zeroCount = 0;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int numA = num1[i] - '0';
                int countB = 0;

                for (int j = num2.Length - 1; j >= 0; j--)
                {
                    int numB = num2[j] - '0';
                    int res = numA * numB;
                    if (res > 0)
                    {
                        zeroCount = countB + countA;
                        if (!dict.ContainsKey(zeroCount))
                        {
                            dict.Add(zeroCount, res);
                        }
                        else
                        {
                            dict[zeroCount] += res;
                        }

                    }
                    countB++;

                }
                countA++;
            }

            int mid = (zeroCount / 2) + 1;
            for (int i = 0; i <= mid; i++)
            {
                if (dict.ContainsKey(i))
                {
                    string zero = "".PadLeft(i, '0');
                    string item = $"{dict[i]}{zero}";
                    if (dict.ContainsKey(item.Length))
                    {

                        if (sum == null)
                        {
                            sum = $"{dict[item.Length]}{item}";

                        }
                        else
                        {
                            string numString = $"{dict[item.Length]}{item}";
                            sum = Add(sum, numString);
                        }
                        dict.Remove(i);
                        dict.Remove(item.Length);

                    }
                }
            }
            foreach (var item in dict)
            {
                string zero = "".PadLeft(item.Key, '0');
                if (sum == null)
                {
                    sum = $"{item.Value}{zero}";
                    continue;
                }

                sum = Add(sum, $"{item.Value}{zero}");

            }

            return sum;
        }

        private string Add(string num1, string num2)
        {
            string min = num1;
            string max = num2;
            if (num2.Length < num1.Length)
            {
                min = num2;
                max = num1;
            }
            int next = 0;
            List<int> list = new List<int>();
            int n = max.Length - 1;
            for (int i = min.Length - 1; i >= 0 && n >= 0; i--, n--)
            {
                int numA = min[i] - '0';
                int numB = max[n] - '0';
                int sum = numA + numB + next;
                next = 0;
                if (sum >= 10)
                {
                    next = 1;
                    list.Add(sum % 10);
                }
                else
                {
                    list.Add(sum);
                }

            }
            for (int i = n; i >= 0; i--)
            {
                int num = max[i] - '0';
                int sum = num + next;
                next = 0;
                if (sum >= 10)
                {
                    next = 1;
                    list.Add(sum % 10);
                }
                else
                {
                    list.Add(sum);
                }
            }
            if (next > 0)
            {
                list.Add(next);
            }

            StringBuilder sb = new StringBuilder();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                sb.Append(list[i]);
            }


            return sb.ToString();
        }

        public string Multiply1(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            int countA = 0;
            string sum = null;
            List<int> list = new List<int>();
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int numA = num1[i] - '0';
                int countB = 0;

                for (int j = num2.Length - 1; j >= 0; j--)
                {
                    int numB = num2[j] - '0';
                    int res = numA * numB;
                    if (res > 0)
                    {
                        string item = res.ToString();
                        item = item.PadRight(item.Length + countB + countA, '0');
                        if (sum == null)
                        {
                            sum = item;
                        }
                        else
                        {
                            sum = Add(sum, item);
                        }
                    }
                    countB++;

                }
                countA++;
            }

            return sum;
        }



    }
}
