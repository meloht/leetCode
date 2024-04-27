using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _318_MaximumProductOfWordLengthsAlg
    {
        public int MaxProduct(string[] words)
        {
            int[][] map = new int[words.Length][];
            for (int i = 0; i < words.Length; i++)
            {
                map[i] = GetArr(words[i]);
            }
            int ans = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (IsContain(map[i], map[j]))
                    {
                        continue;
                    }
                    ans = Math.Max(ans, words[i].Length * words[j].Length);
                }
            }
            return ans;
        }
        private int[] GetArr(string s)
        {
            int[] arr = new int[26];
            foreach (var item in s)
            {
                int index = item - 'a';
                arr[index]++;
            }
            return arr;
        }
        private bool IsContain(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > 0 && arr2[i] > 0)
                    return true;
            }
            return false;
        }
    }
}
