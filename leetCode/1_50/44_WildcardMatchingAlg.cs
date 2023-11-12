using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._1_50
{
    public class _44_WildcardMatchingAlg
    {

        /// <summary>
        /// 贪心算法
        /// </summary>
        /// <returns></returns>
        public bool IsMatch(string s, string p)
        {
            int sRight = s.Length, pRight = p.Length;
            while (sRight > 0 && pRight > 0 && p[pRight - 1] != '*')
            {
                if (charMatch(s[sRight - 1], p[pRight - 1]))
                {
                    --sRight;
                    --pRight;
                }
                else
                {
                    return false;
                }
            }

            if (pRight == 0)
            {
                return sRight == 0;
            }

            int sIndex = 0, pIndex = 0;
            int sRecord = -1, pRecord = -1;

            while (sIndex < sRight && pIndex < pRight)
            {
                if (p[pIndex] == '*')
                {
                    ++pIndex;
                    sRecord = sIndex;
                    pRecord = pIndex;
                }
                else if (charMatch(s[sIndex], p[pIndex]))
                {
                    ++sIndex;
                    ++pIndex;
                }
                else if (sRecord != -1 && sRecord + 1 < sRight)
                {
                    ++sRecord;
                    sIndex = sRecord;
                    pIndex = pRecord;
                }
                else
                {
                    return false;
                }
            }

            return allStars(p, pIndex, pRight);

        }

        public bool allStars(string str, int left, int right)
        {
            for (int i = left; i < right; ++i)
            {
                if (str[i] != '*')
                {
                    return false;
                }
            }
            return true;
        }

        public bool charMatch(char u, char v)
        {
            return u == v || v == '?';
        }



        public bool IsMatch4(string s, string p)
        {
            int s_len = s.Length;
            int p_len = p.Length;
            int s_idx = 0;       //当前s的下标
            int p_idx = 0;       //当前p的下标
            int star_idx = -1;       //离目前匹配字符最近*出现的位置
            int match = 0;      //记录目前匹配到s的第几位字符
            /*
                   abcdec
                   a*c
             */
            while (s_idx < s_len)
            {    //对s进行遍历
                if ((p_idx < p_len) && p[p_idx] != '*' && IsEqual(s[s_idx], p[p_idx]))
                {  //两个字符匹配到
                    s_idx++;
                    p_idx++;
                }
                else if ((p_idx < p_len) && p[p_idx] == '*')
                { //当前p字符为*
                    star_idx = p_idx;    //记录*的位置
                    match = s_idx;      //记录匹配到s的第几位字符
                    p_idx++;                //s不动，p往下遍历,即让*号先匹配0个字符，不行再多匹配
                }
                else if (star_idx != -1)
                {      //当无法匹配，如两个字符不同，或者p已遍历完等情况时，并且之前存在*时
                    p_idx = star_idx + 1;     //让p停止向下遍历，回上一个*号后边
                    match++;    //s继续向下遍历
                    s_idx = match;
                }
                else
                {  //既没有*，又无法匹配，直接返回false
                    return false;
                }
            }
            while (p_idx < p_len && p[p_idx] == '*')
            {  //s被遍历完，p的尾部还有*时，无需匹配
                p_idx++;
            }
            return p_idx == p_len; //s此时肯定被遍历完了，p被遍历完，则成功匹配，否则，不成功
        }
        public bool IsEqual(char c1, char c2)
        {
            return c2 == '?' || c1 == c2;
        }
        public bool IsMatch3(string s, string p)
        {
            int m = s.Length, n = p.Length;
            // dp[i+1][j+1]表示p[0~j]是否能匹配s[0~i]
            List<List<bool>> dp = new List<List<bool>>();
            for (int i = 0; i < m + 1; i++)
            {
                List<bool> ls = new List<bool>();
                for (int j = 0; j < n + 1; j++)
                {
                    ls.Add(false);
                }
                dp.Add(ls);
            }

            dp[0][0] = true;
            for (int i = 1; i <= n; i++)
            {
                if (p[i - 1] == '*') dp[0][i] = true;
                else break;
            }
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    // 当前字符能够匹配
                    if (p[j - 1] == s[i - 1] || p[j - 1] == '?')
                    {
                        dp[i][j] = dp[i - 1][j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        dp[i][j] = dp[i - 1][j] || dp[i - 1][j - 1] || dp[i][j - 1];
                    }
                }
            }
            return dp[m][n];
        }

        public bool IsMatch2(string s, string p)
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

            List<NodeData> list = GetNodeDataList(p);

            HashSet<int> listPath = new HashSet<int>();

            InitBeginEndNode(list, s);
            NodeData node = list[0];
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
        private void InitBeginEndNode(List<NodeData> list, string s)
        {
            var beginNode = list[0];
            if (beginNode.Begin == false && beginNode.End)
            {
                GetNodeIndexFunCache(s, beginNode, 0, beginNode.Item.Length);

            }

            var endNode = list[list.Count - 1];
            if (endNode.Begin && endNode.End == false)
            {
                GetNodeIndexFunCache(s, endNode, s.Length - endNode.Item.Length, s.Length);
            }
        }
        private bool ComputeNodePath(string s, NodeData node, int beginIndex, int endIndex, List<NodeData> list, int index, HashSet<int> listPath, int pNum, int beginLen)
        {
            List<NodeIndex> nodeIndexList = new List<NodeIndex>();
            if (node.Begin && node.End)
            {
                nodeIndexList = GetNodeIndexCache(s, node, beginIndex, endIndex);
            }
            else if (node.Begin == false && node.End)
            {
                nodeIndexList = node.matchDict;
            }
            else if (node.Begin && node.End == false)
            {
                nodeIndexList = node.matchDict;
            }
            if (node.matchDict.Count == 0)
                return false;
            int nextIndex = index + 1;

            if (nextIndex < list.Count)
            {
                bool res = false;
                NodeData nextNode = list[nextIndex];
                int beginLenTemp = beginLen + nextNode.Item.Length;
                int nextEndIndex = s.Length - (pNum - beginLenTemp);
                foreach (var map in node.matchDict)
                {
                    listPath.Add(map.BeginIndex);

                    bool bl = ComputeNodePath(s, nextNode, map.EndIndex + 1, nextEndIndex, list, nextIndex, listPath, pNum, beginLenTemp);
                    if (bl == false)
                    {
                        listPath.Remove(map.BeginIndex);

                        return false;
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
                    listPath.Add(map.BeginIndex);
                    break;
                }
                return true;
            }


        }
        private List<NodeIndex> GetNodeIndexCache(string s, NodeData node, int beginIndex, int endIndex)
        {
            if (node.IsComputeIndex)
            {
                var indexList = node.matchDict.Where(p => p.BeginIndex >= beginIndex).ToList();
                return indexList;
            }
            int index = beginIndex;
            while (index < endIndex)
            {
                GetNodeIndexFunCache(s, node, index, endIndex);
                index++;
            }
            node.IsComputeIndex = true;
            return node.matchDict;

        }
        private void GetNodeIndexFunCache(string s, NodeData node, int beginIndex, int endIndex)
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
                NodeIndex nodeIndex = new NodeIndex();
                nodeIndex.BeginIndex = beginIndex;
                nodeIndex.EndIndex = beginIndex + p.Length - 1;
                node.matchDict.Add(nodeIndex);
            }

        }
        private List<NodeData> GetNodeDataList(string p)
        {
            List<NodeData> list = new List<NodeData>();

            var arr = p.Split("*", StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length > 1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    NodeData node = new NodeData();
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
                NodeData node = new NodeData();
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
        class NodeData
        {
            public bool Begin = false;
            public bool End = false;
            public bool IsComputeIndex = false;
            public string Item;
            public List<NodeIndex> matchDict = new List<NodeIndex>();
            public override string ToString()
            {
                return $"{Item} {matchDict.Count}";
            }
        }
        class NodeIndex
        {
            public int BeginIndex;
            public int EndIndex;
            public override string ToString()
            {
                return $"{BeginIndex} {EndIndex}";
            }
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
        class Node
        {
            public bool Begin = false;
            public bool End = false;
            public string Item;
            public Dictionary<int, int> matchDict = new Dictionary<int, int>();
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

        #endregion
    }
}
