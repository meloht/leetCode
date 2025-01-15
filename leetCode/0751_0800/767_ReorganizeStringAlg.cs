using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _767_ReorganizeStringAlg
    {
        public string ReorganizeString1(string s)
        {
            if (s.Length == 1)
                return s;

            int[] arr = new int[26];
            int max = 0;
            foreach (var ch in s)
            {
                arr[ch - 'a']++;
                max = Math.Max(max, arr[ch - 'a']);
            }

            if (max >= s.Length - max + 2)
            {
                return "";
            }
            PriorityQueue<char, int> queue = new PriorityQueue<char, int>(Comparer<int>.Create((x, y) => y - x));

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    continue;
                }
                queue.Enqueue((char)(i + 'a'), arr[i]);
            }
            StringBuilder sb = new StringBuilder();
            char prevChar = queue.Dequeue();
            while (queue.Count > 0)
            {
                char currChar = queue.Dequeue();
                int prevCount = arr[prevChar - 'a'];
                int currCount = arr[currChar - 'a'];
                int cnt = Math.Min(prevCount, currCount);
                for (int i = 0; i < cnt; i++)
                {
                    if (sb.Length > 0 && sb[sb.Length - 1] == prevChar)
                    {
                        sb.Append(currChar);
                        sb.Append(prevChar);
                    }
                    else
                    {
                        sb.Append(prevChar);
                        sb.Append(currChar);
                    }

                }
                prevCount -= cnt;
                currCount -= cnt;
                arr[prevChar - 'a'] = prevCount;
                arr[currChar - 'a'] = currCount;

                if (prevCount == 0 && currCount == 0)
                {
                    prevChar = '-';
                    if (queue.Count > 0)
                    {
                        prevChar = queue.Dequeue();
                    }
                }
                else if (currCount > 0)
                {
                    prevChar = currChar;
                }
            }

            if (prevChar != '-')
            {
                if (arr[prevChar - 'a'] == 1 && sb[sb.Length - 1] != prevChar)
                {
                    sb.Append(prevChar);
                    return sb.ToString();
                }

                if (arr[prevChar - 'a'] > 0)
                {
                    StringBuilder sbb = new StringBuilder();
                    int count = arr[prevChar - 'a'];
                    for (int i = 0, j = 0; i < sb.Length; i++, j++)
                    {

                        if (j < count)
                        {
                            sbb.Append(prevChar);
                        }
                        sbb.Append(sb[i]);
                    }

                    return sbb.ToString();
                }
            }
            return sb.ToString();

        }

        public string ReorganizeString(string s)
        {
            if (s.Length == 1)
                return s;
            int n = s.Length;
            int[] arr = new int[26];
            int max = 0;
            int maxIdx = 0;
            foreach (var ch in s)
            {
                int idx = ch - 'a';
                arr[idx]++;
                if (arr[idx] > (n + 1) / 2)
                    return "";

                if (arr[idx] > max)
                {
                    maxIdx = idx;
                    max = arr[idx];
                }
            }

            char[] ans = new char[n];
            int i = 0;
            for (; arr[maxIdx] > 0; arr[maxIdx]--)
            {
                ans[i] = (char)(maxIdx + 'a');
                i += 2;
                if (i >= n)
                {
                    i = 1;
                }
            }

            for (int j = 0; j < 26; j++)
            {
                for (; arr[j] > 0; arr[j]--)
                {
                    ans[i] = (char)(j + 'a');
                    i += 2;
                    if (i >= n)
                    {
                        i = 1;
                    }
                }
            }


            return new string(ans);
        }
    }
}
