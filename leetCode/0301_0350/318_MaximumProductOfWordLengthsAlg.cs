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

        public int MaxProduct1(string[] words)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int length = words.Length;
            for (int i = 0; i < length; i++)
            {
                int mask = 0;
                String word = words[i];
                int wordLength = word.Length;
                for (int j = 0; j < wordLength; j++)
                {
                    mask |= 1 << (word[j] - 'a');
                }
                if (dictionary.ContainsKey(mask))
                {
                    if (wordLength > dictionary[mask])
                    {
                        dictionary[mask] = wordLength;
                    }
                }
                else
                {
                    dictionary.Add(mask, wordLength);
                }
            }
            int maxProd = 0;
            foreach (int mask1 in dictionary.Keys)
            {
                int wordLength1 = dictionary[mask1];
                foreach (int mask2 in dictionary.Keys)
                {
                    if ((mask1 & mask2) == 0)
                    {
                        int wordLength2 = dictionary[mask2];
                        maxProd = Math.Max(maxProd, wordLength1 * wordLength2);
                    }
                }
            }
            return maxProd;
        }


    }
}
