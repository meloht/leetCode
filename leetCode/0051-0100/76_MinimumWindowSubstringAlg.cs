using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetCode._51_100
{
    public class _76_MinimumWindowSubstringAlg
    {
        public string MinWindow(string s, string t)
        {
            if (s.Length < t.Length)
                return string.Empty;

            int n = s.Length;
            Dictionary<char, Node> dict = new Dictionary<char, Node>();
            foreach (char c in t)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, new Node() { Total = 1 });
                }
                else
                {
                    dict[c].Total++;
                }
            }
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    index = i;
                    break;
                }
            }

            Queue<char> queue = new Queue<char>();
            HashSet<char> overflowSet = new HashSet<char>(); 
            int actNum = 0;
            int min = n + 1;
            string res = "";


            while (index < n)
            {
                char ch = s[index];
                queue.Enqueue(ch);
                if (dict.ContainsKey(ch))
                {
                    var node = dict[ch];
                    if (node.Count < node.Total)
                    {
                        node.Count++;
                        actNum++;
                    }
                    else if (node.Count == node.Total)
                    {
                        node.OverFlow++;
                        overflowSet.Add(ch);
                    }
                    if (overflowSet.Count > 0)
                    {
                        RemoveQueue(queue, dict, overflowSet);
                    }
                    if (actNum == t.Length)
                    {

                        if (queue.Count < min)
                        {
                            res = string.Join("", queue);
                            min = queue.Count;
                        }
                    }
                }

                index++;
            }


            return res;
        }

        private void RemoveQueue(Queue<char> queue, Dictionary<char, Node> dict, HashSet<char> overflowSet)
        {
            while (queue.Count > 0)
            {
                var test = queue.Peek();
                if (dict.ContainsKey(test))
                {
                    var node = dict[test];
                    if (overflowSet.Contains(test) && node.OverFlow > 0)
                    {
                        queue.Dequeue();
                        node.OverFlow--;
                        if (node.OverFlow == 0)
                        {
                            overflowSet.Remove(test);
                        }
                    }
                    else if (!dict.ContainsKey(test))
                    {
                        queue.Dequeue();
                    }
                    else if (dict.ContainsKey(test) && !overflowSet.Contains(test))
                    {
                        break;
                    }
                }
                else
                {
                    queue.Dequeue();
                }
               
            }
        }

        class Node
        {
            public int Total;
            public int Count;
            public int OverFlow;
        }

        public string MinWindow1(string s, string t)
        {
            if (s.Length < t.Length)
                return string.Empty;

            int n = s.Length;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c]++;
                }
            }
            List<int> arr = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    arr.Add(i);
                }
            }
            if (arr.Count == 0 || arr.Count < t.Length)
                return string.Empty;

            string res = "";
            int min = n + 1;
            StringBuilder sb = new StringBuilder();
            bool bl = false;
            for (int j = 0; j < arr.Count; j++)
            {
                if (bl)
                {
                    int total = n - arr[j];
                    if (total < t.Length)
                        break;

                    bl = false;
                }
                sb.Clear();
                Dictionary<char, int> dictTemp = new Dictionary<char, int>(dict);

                int count = 0;

                for (int i = arr[j]; i < n; i++)
                {
                    sb.Append(s[i]);
                    if (dictTemp.ContainsKey(s[i]))
                    {
                        dictTemp[s[i]]--;
                        if (dictTemp[s[i]] == 0)
                        {
                            dictTemp.Remove(s[i]);
                            if (dictTemp.Count == 0)
                            {
                                if ((count + 1) < min)
                                {
                                    res = sb.ToString();
                                    min = count + 1;
                                    bl = true;
                                    break;
                                }
                            }
                        }
                    }

                    count++;
                }

            }
            return res;
        }


    }
}
