using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _87_ScrambleStringAlg
    {
        public bool IsScramble(string s1, string s2)
        {
            int n = s1.Length;
            bool[,,] dp = new bool[n + 1, n + 1, n + n];
            for (int k = 1; k <= n; ++k) //分割长度
            {
                for (int i = 0; i + k <= n; ++i) //枚举两个字符串的枚举下标
                {
                    for (int j = 0; j + k <= n; ++j)
                    {
                        if (k == 1)
                        {
                            dp[i, j, k] = s1[i] == s2[j];
                            continue;
                        }
                        for (int u = 1; u < k; ++u)//枚举分割点
                        {
                            bool o1 = dp[i, j, u] && dp[i + u, j + u, k - u];//不交换数据
                            bool o2 = dp[i, j + k - u, u] && dp[i + u, j, k - u];//交换数据
                            if (o1 || o2)
                            {
                                dp[i, j, k] = true;
                                break;
                            }

                        }

                    }

                }

            }

            return dp[0, 0, n];
        }

        public bool IsScramble2(string s1, string s2)
        {

            bool bl = AddAllList(s1, s2);

            return bl;
        }


        private bool IsSame(string arr1, string arr2)
        {
            if (arr1 == arr2)
                return true;
            char[] s1 = arr1.ToCharArray();
            char[] s2 = arr2.ToCharArray();
            Array.Sort(s1);
            Array.Sort(s2);

            if (s1.SequenceEqual(s2))
                return true;
            return false;
        }



        private bool AddAllList(string s1, string target)
        {
            if (s1 == target)
                return true;
            if (s1.Length == 2)
            {
                return IsSame(s1, target);
            }

            HashSet<int> dictLeft = new HashSet<int>();
            HashSet<int> dictRight = new HashSet<int>();
            for (int i = 1; i < s1.Length; i++)
            {
                var sourceLeft = s1.Substring(0, i);
                var sourceRight = s1.Substring(i, s1.Length - i);
                var targetLeft = target.Substring(0, i);
                var targetRight = target.Substring(i, s1.Length - i);

                if (IsSame(sourceLeft, targetLeft) && IsSame(sourceRight, targetRight))
                {
                    if (dictLeft.Contains(i - 1))
                    {
                        return false;
                    }

                    bool bl = IsSameString(sourceLeft, sourceRight, targetLeft, targetRight);
                    if (bl)
                    {
                        System.Diagnostics.Debug.WriteLine($"{sourceLeft}-{sourceRight} == {targetLeft}-{targetRight} ");
                        return true;
                    }
                    else
                    {
                        dictLeft.Add(i);

                    }
                }

                var targetLeft2 = target.Substring(s1.Length - i, i);
                var targetRight2 = target.Substring(0, s1.Length - i);
                if (IsSame(sourceLeft, targetLeft2) && IsSame(sourceRight, targetRight2))
                {
                    if (dictRight.Contains(i - 1))
                    {
                        return false;
                    }

                    bool bl = IsSameString(sourceLeft, sourceRight, targetLeft2, targetRight2);
                    if (bl)
                    {
                        System.Diagnostics.Debug.WriteLine($"{sourceLeft}-{sourceRight} == {targetLeft2}-{targetRight2} ");
                        return true;
                    }
                    else
                    {
                        dictRight.Add(i);
                    }

                }
            }

            return false;
        }


        private bool IsSameString(string sourceLeft, string sourceRight, string targetLeft, string targetRight)
        {

            var set1 = AllList(sourceLeft, targetLeft);
            var set2 = AllList(sourceRight, targetRight);

            if (set1 && set2)
                return true;

            return false;
        }

        private bool AllList(string s1, string target)
        {
            if (target == s1)
                return true;
            if (s1.Length == 2)
            {
                return IsSame(s1, target);
            }
            HashSet<int> dictLeft = new HashSet<int>();
            HashSet<int> dictRight = new HashSet<int>();
            for (int i = 1; i < s1.Length; i++)
            {

                var left1 = s1.Substring(0, i);
                var right1 = s1.Substring(i, s1.Length - i);

                var left2 = target.Substring(0, i);
                var right2 = target.Substring(i, s1.Length - i);

                var left3 = target.Substring(s1.Length - i, i);
                var right3 = target.Substring(0, s1.Length - i);


                if (IsSame(left1, left2) && IsSame(right1, right2))
                {
                    //if (dictLeft.Contains(i - 1))
                    //{
                    //    return false;
                    //}
                    var set1 = AllList(left1, left2);

                    var set2 = AllList(right1, right2);

                    if (set1 && set2)
                        return true;
                    else
                    {
                        dictLeft.Add(i);
                    }
                }
              
                if (IsSame(left1, left3) && IsSame(right1, right3))
                {
                    if (dictRight.Contains(i - 1))
                    {
                        return false;
                    }
                    var set1 = AllList(left1, left3);

                    var set2 = AllList(right1, right3);

                    if (set1 && set2)
                        return true;
                    else
                    {
                        dictRight.Add(i);
                    }
                }
              

            }
            return false;
        }

    }
}
