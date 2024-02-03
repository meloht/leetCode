using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _306_AdditiveNumberAlg
    {
        public bool IsAdditiveNumber1(string num)
        {
            if (num.Length < 3)
                return false;
            int n = num.Length / 2;
            ReadOnlySpan<char> span = num.AsSpan();
            for (int j = 1; j <= n; j++)
            {
                int num0 = j;

                for (int k = j + 1; k < num.Length; k++)
                {
                    int num1 = k - j;
                    int num2 = num.Length - num0 - num1;
                    if (num2 < num0 || num2 < num1)
                        break;
                    bool bl = Dfs(span, 0, j, k);
                    if (bl)
                        return true;
                }

            }
            return false;
        }
        private bool Dfs(ReadOnlySpan<char> num, int f0, int f1, int f2)
        {
            if (f2 >= num.Length)
                return false;
            var num0 = num.Slice(f0, f1 - f0);
            if (IsValid(num0) == false)
                return false;
            var num1 = num.Slice(f1, f2 - f1);
            if (IsValid(num1) == false)
                return false;
            var sum = AddStrings(num0, num1);
            if (f2 + sum.Length > num.Length)
                return false;
            var num3 = num.Slice(f2, sum.Length);
            if (IsValid(num3) == false)
                return false;
            if (!sum.SequenceEqual(num3))
            {
                return false;
            }
            if (f2 + sum.Length == num.Length)
                return true;
            bool bl = Dfs(num, f1, f2, f2 + sum.Length);
            if (bl == false)
                return false;
            return true;
        }

        private bool IsValid(ReadOnlySpan<char> num)
        {
            if (num.Length > 1 && num[0] == '0')
                return false;
            return true;
        }
        public static ReadOnlySpan<char> AddStrings(ReadOnlySpan<char> num1, ReadOnlySpan<char> num2)
        {
            int i = num1.Length - 1, j = num2.Length - 1, add = 0;
            List<int> ans = new List<int>();
            while (i >= 0 || j >= 0 || add != 0)
            {
                int x = i >= 0 ? num1[i] - '0' : 0;
                int y = j >= 0 ? num2[j] - '0' : 0;
                int result = x + y + add;
                ans.Add(result % 10);
                add = result / 10;
                i--;
                j--;
            }
            StringBuilder sb = new StringBuilder();
            for (int k = ans.Count - 1; k >= 0; k--)
            {
                sb.Append(ans[k]);
            }
            return sb.ToString().AsSpan();
        }


        public bool IsAdditiveNumber(string num)
        {
            if (num.Length < 3)
                return false;
            int n = num.Length / 2;

            for (int j = 1; j <= n; j++)
            {
                int num0 = j;

                for (int k = j + 1; k < num.Length; k++)
                {
                    int num1 = k - j;
                    int num2 = num.Length - num0 - num1;
                    if (num2 < num0 || num2 < num1)
                        break;
                    bool bl = Dfs(num, 0, j, k);
                    if (bl)
                        return true;
                }

            }
            return false;
        }
        private bool Dfs(string num, int f0, int f1, int f2)
        {
            if (f2 >= num.Length)
                return false;
            string num0 = num.Substring(f0, f1 - f0);
            if (IsValid(num0) == false)
                return false;
            string num1 = num.Substring(f1, f2 - f1);
            if (IsValid(num1) == false)
                return false;
            string sum = AddStrings(num0, num1);
            if (f2 + sum.Length > num.Length)
                return false;
            string num3 = num.Substring(f2, sum.Length);
            if (IsValid(num3) == false)
                return false;
            if (sum != num3)
            {
                return false;
            }
            if (f2 + sum.Length == num.Length)
                return true;
            bool bl = Dfs(num, f1, f2, f2 + sum.Length);
            if (bl == false)
                return false;
            return true;
        }

        private bool IsValid(string num)
        {
            if (num.Length > 1 && num.StartsWith("0"))
                return false;
            return true;
        }
        public static string AddStrings(string num1, string num2)
        {
            int i = num1.Length - 1, j = num2.Length - 1, add = 0;
            List<int> ans = new List<int>();
            while (i >= 0 || j >= 0 || add != 0)
            {
                int x = i >= 0 ? num1[i] - '0' : 0;
                int y = j >= 0 ? num2[j] - '0' : 0;
                int result = x + y + add;
                ans.Add(result % 10);
                add = result / 10;
                i--;
                j--;
            }
            StringBuilder sb = new StringBuilder();
            for (int k = ans.Count - 1; k >= 0; k--)
            {
                sb.Append(ans[k]);
            }
            return sb.ToString();
        }


    }
}
