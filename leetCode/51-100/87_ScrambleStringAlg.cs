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
        public bool IsScramble2(string s1, string s2)
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

        public bool IsScramble1(string s1, string s2)
        {

            //bool bl = AllList(s1, s2);
            bool bl = IsScramble(s1, s2);
            //bool bl = IsScramble2(s1, s2);
            return bl;
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
                System.Diagnostics.Debug.WriteLine($"{left1}-{right1}  {left2}-{right2} {left3}-{right3}");

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

        public bool IsScramble(string s1, string s2)
        {
            if (s1 == s2)
                return true;

            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            int len = s1.Length;
            for (int i = 0; i < len; i++)
            {
                bool bl = s1[i] == s2[i];
                AddDictCache(i, i, 1, bl, dict);
            }
            bool blRes = IsScrambleRec(0, s1.Length - 1, 0, s1.Length - 1, s1, s2, dict);
            Console.WriteLine(blRes);
            return blRes;
        }

        private bool IsScrambleRec(int ibegin, int iend, int jbegin, int jend, string s1, string s2, 
            Dictionary<string, bool> dict)
        {
            int len = iend - ibegin + 1;
            var tupe = CheckDictCache(ibegin, jbegin, len, dict);
            if (tupe.Item1)
            {
                return tupe.Item2;
            }

            string ss111 = s1.Substring(ibegin, len);
            string ss222 = s2.Substring(jbegin, len);
            if (ss111 == ss222)
            {
                AddDictCache(ibegin, jbegin, len, true, dict);
                return true;
            }

            if (len == 2)
            {
                string ss1 = s1.Substring(ibegin, len);
                string ss2 = s2.Substring(jbegin, len);
                bool bl = IsSame(ss1, ss2);
                AddDictCache(ibegin, jbegin, len, bl, dict);
                return bl;
            }

            for (int i = ibegin + 1, j = jbegin + 1; i <= iend && j <= jend; i++, j++)
            {
                int ileft = ibegin;
                int iright = i;

                int leftLen = i - ibegin;
                int rightLen = len - leftLen;

                int jleft1 = jbegin;
                int jright1 = j;

                int jleft2 = (jend + 1) - leftLen;
                int jright2 = jbegin;

                int ileftend = ileft + (leftLen - 1);
                int irightend = iright + (rightLen - 1);

                int jleft1end = jleft1 + (leftLen - 1);
                int jright1end = jright1 + (rightLen - 1);

                int jleft2end = jleft2 + (leftLen - 1);
                int jright2end = jright2 + (rightLen - 1);

                string ss1left = s1.Substring(ileft, leftLen);
                string ss1right = s1.Substring(iright, rightLen);

                string ss2left1 = s2.Substring(jleft1, leftLen);
                string ss2right1 = s2.Substring(jright1, rightLen);

                string ss2left2 = s2.Substring(jleft2, leftLen);
                string ss2right2 = s2.Substring(jright2, rightLen);
 
                bool bl1 = IsSame(ss1left, ss2left1);
                bool bl2 = IsSame(ss1right, ss2right1);
                if (bl1 && bl2)
                {
                    bool blleft = IsScrambleRec(ileft, ileftend, jleft1, jleft1end, s1, s2, dict);
                    bool blright = IsScrambleRec(iright, irightend, jright1, jright1end, s1, s2, dict);
                    AddDictCache(ileft, jleft1, leftLen, blleft, dict);
                    AddDictCache(iright, jright1, rightLen, blright, dict);

                    if (blleft && blright)
                        return true;
                }
                else
                {
                    AddDictCache(ileft, jleft1, leftLen, false, dict);
                    AddDictCache(iright, jright1, rightLen, false, dict);
                }

                bool bl11 = IsSame(ss1left, ss2left2);
                bool bl22 = IsSame(ss1right, ss2right2);
                if (bl11 && bl22)
                {
                    bool blleft = IsScrambleRec(ileft, ileftend, jleft2, jleft2end, s1, s2, dict);
                    bool blright = IsScrambleRec(iright, irightend, jright2, jright2end, s1, s2, dict);
                    AddDictCache(ileft, jleft2, leftLen, blleft, dict);
                    AddDictCache(iright, jright2, rightLen, blright, dict);

                    if (blleft && blright)
                        return true;
                }
                else
                {
                    AddDictCache(ileft, jleft2, leftLen, false, dict);
                    AddDictCache(iright, jright2, rightLen, false, dict);
                }
            }

            return false;
        }

        private void AddDictCache(int ibegin, int jbegin, int len, bool bl, Dictionary<string, bool> dict)
        {
            string key = $"{ibegin}-{jbegin}_{len}";
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, bl);
            }
        }

        private Tuple<bool, bool> CheckDictCache(int ibegin, int jbegin, int len, Dictionary<string, bool> dict)
        {
            string key = $"{ibegin}-{jbegin}_{len}";
            if (dict.ContainsKey(key))
            {
                bool bl = dict[key];
                return new Tuple<bool, bool>(true, bl);
            }
            return new Tuple<bool, bool>(false, false);
        }

    }
}
