using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _72_EditDistanceAlg
    {


        public string GetLongestCommonSubsequence(string text1, string text2)
        {
            int[,] dp = new int[text1.Length + 1, text2.Length + 1];
            int[,] rec = new int[text1.Length + 1, text2.Length + 1];
            for (int i = 0; i < text1.Length; i++)
            {
                dp[i, 0] = 0;
            }
            for (int j = 0; j < text2.Length; j++)
            {
                dp[0, j] = 0;
            }
            for (int i = 1; i <= text1.Length; i++)
            {
                for (int j = 1; j <= text2.Length; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                        rec[i, j] = 1;

                    }
                    else if (dp[i - 1, j] >= dp[i, j - 1])
                    {
                        dp[i, j] = dp[i - 1, j];
                        rec[i, j] = -1;
                    }
                    else
                    {
                        dp[i, j] = dp[i, j - 1];

                        rec[i, j] = -2;
                    }
                }
            }
            List<char> ls = new List<char>();

            PrintLCS(rec, text1, text1.Length, text2.Length, ls);

            string ss = string.Join("", ls);
            return ss;
        }

        private void PrintLCS(int[,] rec, string text1, int i, int j, List<char> ls)
        {
            if (i == 0 || j == 0)
            {
                return;
            }
            if (rec[i, j] == 1)
            {
                PrintLCS(rec, text1, i - 1, j - 1, ls);
                ls.Add(text1[i - 1]);
            }
            else if (rec[i, j] == -1)
            {
                PrintLCS(rec, text1, i - 1, j, ls);
            }
            else
            {
                PrintLCS(rec, text1, i, j - 1, ls);
            }
        }

        public int MinDistance(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word1))
                return word2.Length;

            if (string.IsNullOrEmpty(word2))
                return word1.Length;

            var list = AllLongestCommonSubsequences(word1, word2);

            int min = Math.Max(word2.Length, word1.Length);
            foreach (var item in list)
            {
                if (item.Count == 0)
                    continue;
                string sss = string.Join("", item.Select(p => p.Value));
                Node begin = item[0];
                Node end = item[item.Count - 1];

                int tem = 0;
                tem = tem + Math.Max(begin.Index2, begin.Index1);
                tem = tem + Math.Max(word2.Length - (end.Index2 + 1), word1.Length - (end.Index1 + 1));

                int dd = GetLessOrDel(item);
                tem += dd;
                min = Math.Min(min, tem);
            }


            return min;
        }

        private int GetLessOrDel(List<Node> list)
        {
            if (list.Count < 2)
                return 0;
            int num = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var node = list[i];
                int next = i + 1;
                if (next < list.Count)
                {
                    var nextNode = list[next];
                    int del2 = nextNode.Index2 - node.Index2;
                    int del1 = nextNode.Index1 - node.Index1;
                    if (del2 > 1)
                    {
                        if (del1 > 1)
                        {
                            num += Math.Max(del1 - 1, del2 - 1);
                        }
                        else
                        {
                            num += (del2 - 1);
                        }
                    }
                    else
                    {
                        if (del1 > 1)
                        {
                            num += (del1 - 1);
                        }

                    }
                }

            }
            return num;
        }

        private class Node
        {
            public char Value;
            public int Index1;
            public int Index2;
            public Node(char value, int index1, int index2)
            {
                this.Value = value;
                this.Index1 = index1;
                this.Index2 = index2;
            }
        }


        private List<List<Node>> AllLongestCommonSubsequences(string text1, string text2)
        {
            int[,] dp = new int[text1.Length + 1, text2.Length + 1];

            for (int i = 0; i <= text1.Length; i++)
            {
                for (int j = 0; j <= text2.Length; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }
                    else if (text1[i - 1] == text2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            int length = dp[text1.Length, text2.Length];

            List<List<Node>> result = new List<List<Node>>();
            HashSet<string> set = new HashSet<string>();
            List<Node> list = new List<Node>();

            GetAllLongestCommonSubsequences(text1, text2, text1.Length, text2.Length, dp, "", result, list.ToArray(), set);

            return result;
        }

        private void GetAllLongestCommonSubsequences(string text1, string text2, int m, int n, int[,] dp, string currentLcs,
            List<List<Node>> result, Node[] list, HashSet<string> set)
        {
            if (m == 0 || n == 0)
            {
                if (!set.Contains(currentLcs))
                {
                    set.Add(currentLcs);
                    List<Node> res = new List<Node>();
                    for (int i = list.Length - 1; i >= 0; i--)
                    {
                        res.Add(list[i]);
                    }
                    result.Add(res);
                }
                return;
            }

            if (text1[m - 1] == text2[n - 1])
            {
                currentLcs = $"{text1[m - 1]}{currentLcs}";
                Node node = new Node(text2[n - 1], m - 1, n - 1);
                var arr = list.ToList();
                arr.Add(node);

                GetAllLongestCommonSubsequences(text1, text2, m - 1, n - 1, dp, currentLcs, result, arr.ToArray(), set);

            }
            else
            {
                if (dp[m - 1, n] >= dp[m, n - 1])
                {
                    GetAllLongestCommonSubsequences(text1, text2, m - 1, n, dp, currentLcs, result, list, set);

                }

                if (dp[m, n - 1] >= dp[m - 1, n])
                {
                    GetAllLongestCommonSubsequences(text1, text2, m, n - 1, dp, currentLcs, result, list, set);

                }
            }
        }
    }
}
