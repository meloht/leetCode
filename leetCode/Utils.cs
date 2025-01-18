using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    internal class Utils
    {
        /// <summary>
        /// 1_000_000_007
        /// </summary>
        public static int Mod = 1_000_000_007;
        public static int gcd(int a, int b)
        {
            return b != 0 ? gcd(b, a % b) : a;
        }
        public int Gcd(int x, int y)
        {
            return x == 0 ? y : Gcd(y % x, x);
        }

        /// <summary>
        /// 最大公约数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }
        /// <summary>
        /// 判断是否是质数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;

            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        /// <summary>
        /// 二进制数1的个数
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int BitCount(int i)
        {
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            i = (i + (i >> 4)) & 0x0f0f0f0f;
            i = i + (i >> 8);
            i = i + (i >> 16);
            return i & 0x3f;
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

        /// <summary>
        /// 十进制转二进制
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static string Binary(int x)
        {
            string s = string.Empty;
            while (x != 0)
            {
                s = s + (x & 1);
                x >>= 1;
            }
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string Binary2(int decimalNumber)
        {
            // 如果输入为0，直接返回 "0"
            if (decimalNumber == 0)
                return "0";

            string binaryNumber = string.Empty;

            // 进行除2取余法转换
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binaryNumber = remainder + binaryNumber;
                decimalNumber /= 2;
            }

            return binaryNumber;
        }


        /// <summary>
        /// 求长度为k的子序列
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public List<List<int>> FindSubsequencesOfLengthK(int[] nums, int k)
        {
            List<List<int>> result = new List<List<int>>();
            int n = nums.Length;
            if (k < 0 || k > n)
            {
                return result;
            }
            int[] indices = new int[k];
            for (int i = 0; i < k; i++)
            {
                indices[i] = i;
            }
            while (true)
            {
                List<int> subSeq = new List<int>();
                foreach (int index in indices)
                {
                    subSeq.Add(nums[index]);
                }
                result.Add(subSeq);
                int i;
                for (i = k - 1; i >= 0 && indices[i] == n - k + i; i--) ;
                if (i < 0)
                {
                    break;
                }
                indices[i]++;
                for (int j = i + 1; j < k; j++)
                {
                    indices[j] = indices[j - 1] + 1;
                }
            }
            return result;
        }
        /// <summary>
        ///  求长度为k的子序列
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public List<List<int>> GenerateSubsequences(int[] arr, int k)
        {
            var result = new List<List<int>>();
            Backtrack(arr, k, 0, new List<int>(), result);
            return result;
        }

        static void Backtrack(int[] arr, int k, int start, List<int> path, List<List<int>> result)
        {
            // If the current path's length is k, add it to the result
            if (path.Count == k)
            {
                result.Add(new List<int>(path));
                return;
            }
            // Explore further elements to add to the path
            for (int i = start; i < arr.Length; i++)
            {
                path.Add(arr[i]);
                Backtrack(arr, k, i + 1, path, result);
                path.RemoveAt(path.Count - 1); // backtrack, remove the last element
            }
        }


    }
}
