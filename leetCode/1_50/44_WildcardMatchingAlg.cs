using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetCode._1_50
{
    public class _44_WildcardMatchingAlg
    {

        public bool IsMatch(string s, string p)
        {
            bool blX = p.Contains("*");
            bool blY = p.Contains("?");
            if (!blX && !blY)
                return s == p;

            if (p == "*")
                return true;

            if (!blX && p.Length != s.Length)
            {
                return false;
            }

            if (!blX)
            {
                return CompareString(s, p);
            }
            string itemWithout = p.Replace("*", "");
            if (itemWithout.Length > s.Length)
                return false;

            if (itemWithout.Length == 0)
                return true;

            if (itemWithout.Length == s.Length)
            {
                if (itemWithout == s)
                {
                    return true;
                }
                else
                {
                    return CompareString(s, itemWithout);
                }
            }

            List<Node> list = GetNodeList(p);

            HashSet<int> listPath = new HashSet<int>();

            Node node = list[0];
            int beginLen = node.Item.Length;
            int beginIndex = 0;
            int endIndex = s.Length - (itemWithout.Length - node.Item.Length);
            bool bl = ComputeNodePath(s, node, beginIndex, endIndex, list, 0, listPath, itemWithout.Length, beginLen);
            if (listPath.Count == list.Count && bl)
            {
                return true;
            }
            return false;
        }
        private bool ComputeNodePath(string s, Node node, int beginIndex, int endIndex, List<Node> list, int index, HashSet<int> listPath, int pNum, int beginLen)
        {

            if (node.Begin && node.End)
            {
                GetNodeIndex(s, node, beginIndex, endIndex);
            }
            else if (node.Begin == false && node.End)
            {
                GetNodeIndexFun(s, node, 0, node.Item.Length);
            }
            else if (node.Begin && node.End == false)
            {
                GetNodeIndexFun(s, node, s.Length - node.Item.Length, s.Length);
            }
            if (node.matchDict.Count == 0)
                return false;
            int nextIndex = index + 1;

            if (nextIndex < list.Count)
            {
                bool res = false;
                Node nextNode = list[nextIndex];
                int beginLenTemp = beginLen + nextNode.Item.Length;
                int nextEndIndex = s.Length - (pNum - beginLenTemp);
                foreach (var map in node.matchDict)
                {
                    listPath.Add(map.Key);

                    bool bl = ComputeNodePath(s, nextNode, map.Value + 1, nextEndIndex, list, nextIndex, listPath, pNum, beginLenTemp);
                    if (bl == false)
                    {
                        listPath.Remove(map.Key);

                    }
                    else
                    {
                        res = true;
                        break;
                    }

                }
                return res;

            }
            else
            {
                foreach (var map in node.matchDict)
                {
                    listPath.Add(map.Key);
                    break;
                }
                return true;
            }


        }
        private void GetNodeIndex(string s, Node node, int beginIndex, int endIndex)
        {
            int index = beginIndex;
            while (index < endIndex)
            {
                GetNodeIndexFun(s, node, index, endIndex);
                index++;
            }

        }
        private void GetNodeIndexFun(string s, Node node, int beginIndex, int endIndex)
        {
            int count = 0;
            string p = node.Item;
            for (int i = beginIndex, j = 0; i < endIndex && j < p.Length; i++, j++)
            {
                if (s[i] == p[j] || p[j] == '?')
                {
                    count++;
                }
                else
                {
                    break;
                }

            }
            if (count == p.Length)
            {
                if (!node.matchDict.ContainsKey(beginIndex))
                {
                    node.matchDict.Add(beginIndex, beginIndex + p.Length - 1);
                }
              
            }
        }
        private List<Node> GetNodeList(string p)
        {
            List<Node> list = new List<Node>();

            var arr = p.Split("*", StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length > 1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Node node = new Node();
                    node.Item = arr[i];
                    if (i == 0)
                    {
                        if (p[0] == '*')
                        {
                            node.Begin = true;
                        }

                        node.End = true;
                    }
                    else if (i == arr.Length - 1)
                    {
                        if (p[p.Length - 1] == '*')
                        {
                            node.End = true;
                        }
                        node.Begin = true;
                    }
                    else
                    {
                        node.Begin = true;
                        node.End = true;
                    }
                    list.Add(node);
                }
            }
            else
            {
                Node node = new Node();
                node.Item = arr[0];
                if (p[0] == '*')
                {
                    node.Begin = true;
                }
                if (p[p.Length - 1] == '*')
                {
                    node.End = true;
                }
                list.Add(node);
            }

            return list;

        }
        class Node
        {
            public bool Begin = false;
            public bool End = false;
            public string Item;
            public Dictionary<int, int> matchDict = new Dictionary<int, int>();
        }
        private bool CompareString(string s, string p)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (p[i] != '?' && p[i] != s[i])
                {
                    return false;
                }
            }
            return true;
        }

        #region 解法1


        public bool IsMatch1(string s, string p)
        {
            bool blX = p.Contains("*");
            bool blY = p.Contains("?");
            if (!blX && !blY)
                return s == p;

            if (p == "*")
                return true;

            if (!blX && p.Length != s.Length)
            {
                return false;
            }

            if (!blX)
            {
                return CompareString(s, p);
            }
            string itemWithout = p.Replace("*", "");
            if (itemWithout.Length > s.Length)
                return false;

            if (itemWithout.Length == 0)
                return true;

            if (itemWithout.Length == s.Length)
            {
                if (itemWithout == s)
                {
                    return true;
                }
                else
                {
                    return CompareString(s, itemWithout);
                }
            }

            List<Node> list = GetNodeList(p);
            int beginIndex = 0;
            int BeginLen = 0;
            int endIndex = 0;
            for (int j = 0; j < list.Count; j++)
            {
                Node node = list[j];
                BeginLen += node.Item.Length;
                endIndex = s.Length - (itemWithout.Length - BeginLen);
                ComputeNode(s, node, beginIndex, endIndex);
                beginIndex += node.Item.Length;
            }

            bool bl = GetPath(0, -1, list);
            return bl;

        }
        private bool GetPath(int currentIndex, int preIndex, List<Node> list)
        {
            if (currentIndex < list.Count)
            {
                Node node = list[currentIndex];
                if (node.matchDict.Count == 0)
                    return false;
                var keys = node.matchDict.Keys.Where(p => p > preIndex).ToArray();
                foreach (var key in keys)
                {
                    bool bl = GetPath(currentIndex + 1, node.matchDict[key], list);
                    if (bl)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return true;
            }

        }
        private void ComputeNode(string s, Node node, int beginIndex, int endIndex)
        {
            if (node.Begin && node.End)
            {
                GetNodeIndex(s, node, beginIndex, endIndex);
            }
            else if (node.Begin == false && node.End)
            {
                GetNodeIndexFun(s, node, 0, node.Item.Length);
            }
            else if (node.Begin && node.End == false)
            {
                GetNodeIndexFun(s, node, s.Length - node.Item.Length, s.Length);
            }


        }





        #endregion
    }
}
