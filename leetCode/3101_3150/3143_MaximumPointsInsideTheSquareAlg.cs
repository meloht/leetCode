using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3143_MaximumPointsInsideTheSquareAlg
    {
        public int MaxPointsInsideSquare(int[][] points, string s)
        {
            Dictionary<int[], int> dict = new Dictionary<int[], int>();
            for (int i = 0; i < points.Length; i++)
            {
                dict.Add(points[i], i);
            }
            Array.Sort(points, SortPoint);
            int ans = 0;
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < points.Length; i++)
            {
                int[] p1 = points[i];
                var ch1 = s[dict[p1]];
                if (set.Contains(ch1))
                    return ans;
                HashSet<char> ls = new HashSet<char>();
                ls.Add(ch1);
                int cnt = 1;
                int d = Math.Max(Math.Abs(p1[0]), Math.Abs(p1[1]));
                for (int j = i + 1; j < points.Length; j++)
                {
                    int[] p2 = points[j];
                    var ch2 = s[dict[p2]];
                    int d2 = Math.Max(Math.Abs(p2[0]), Math.Abs(p2[1]));
                    if (d2 == d)
                    {
                        if(!ls.Add(ch2))
                        {
                            return ans;
                        }
                        i = j;
                        cnt++;
                    }
                    else
                    {
                        break;
                    }
                }
                foreach (var item in ls)
                {
                    if(set.Add(item)==false)
                        return ans;
                }
                ans += cnt;

            }
           
            return ans;
        }

        private int SortPoint(int[] p1, int[] p2)
        {
            int n1 = Math.Max(Math.Abs(p1[0]), Math.Abs(p1[1]));
            int n2 = Math.Max(Math.Abs(p2[0]), Math.Abs(p2[1]));
            return n1.CompareTo(n2);
        }

        public int MaxPointsInsideSquare2(int[][] points, string s)
        {
            int[] min1 = new int[26];
            Array.Fill(min1, int.MaxValue);
            int min2 = int.MaxValue;
            int n = s.Length;
            for (int i = 0; i < n; ++i)
            {
                int x = points[i][0], y = points[i][1], j = s[i] - 'a';
                int d = Math.Max(Math.Abs(x), Math.Abs(y));
                if (d < min1[j])
                {
                    min2 = Math.Min(min2, min1[j]);
                    min1[j] = d;
                }
                else if (d < min2)
                {
                    min2 = d;
                }
            }
            int res = 0;
            foreach (int d in min1)
            {
                if (d < min2)
                {
                    ++res;
                }
            }
            return res;
        }
    }
}
