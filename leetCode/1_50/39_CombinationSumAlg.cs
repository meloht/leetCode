using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetCode._1_50
{
    public class _39_CombinationSumAlg
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<int> listMin = new List<int>();

            foreach (var item in candidates)
            {
                if (item <= target)
                {
                    listMin.Add(item);
                }
            }
            listMin.Sort();
            IList<IList<int>> res = new List<IList<int>>();
            if (listMin.Count == 0)
            {
                return res;
            }
            List<NumNode> listNode = new List<NumNode>();
            Dictionary<int, NumNode> dict = new Dictionary<int, NumNode>();
            int index = 0;
            foreach (var item in listMin)
            {
                NumNode node = new NumNode();
                node.Remainder = target % item;
                node.Value = item;
                node.Count = target / item;
                node.Index = index;

                listNode.Add(node);

                dict.Add(index, node);
                index++;


            }
            foreach (var item in listNode)
            {
                GetNodeCount(item, listMin, target, dict);
            }

            foreach (var item in listNode)
            {
                foreach (var item2 in item.List)
                {
                    res.Add(item2);
                }
            }

            return res;
        }
        private void GetNodeCount(NumNode node, List<int> listMin, int target, Dictionary<int, NumNode> dict)
        {
            int numCount = node.Count;
            int diff = node.Remainder;
            if (node.Remainder == 0 && node.Count > 0)
            {
                node.List.Add(AddNum(node.Value, node.Count));
                if (numCount > 2)
                {
                    numCount -= 2;
                }
                else
                {
                    return;
                }
            }
            else
            {
                numCount--;
            }

            int sum = 0;
            for (int i = 1; i <= numCount; i++)
            {
                List<int> arr = AddNum(node.Value, i);
                sum = node.Value * i;
                diff = target - sum;

                AddNextNum(arr, node, diff, node.Index + 1, dict, listMin);

            }

        }
        private void AddNextNum(List<int> preList, NumNode node, int diff, int nextIndex, Dictionary<int, NumNode> dict, List<int> listMin)
        {
            List<int> list = new List<int>(preList);

            for (int i = nextIndex; i < dict.Count; i++)
            {
                int nextNum = listMin[i];
                var nextNumNode = dict[i];
                if (nextNum > diff)
                {
                    break;
                }
                else if (diff == nextNum)
                {

                    list.Add(nextNum);
                    node.List.Add(list);
                    list = new List<int>(preList);
                    break;

                }
                else
                {
                    int ress = diff % nextNum;
                    int nextCount = diff / nextNum;
                    if (ress == 0)
                    {
                        AddNumList(nextNum, nextCount, list);
                        node.List.Add(list);
                        list = new List<int>(preList);
                        nextCount--;
                    }
                    while (nextCount > 0)
                    {
                        int diffff = diff - nextNum * nextCount;

                        if (diffff > nextNum)
                        {
                            AddNumList(nextNum, nextCount, list);
                            AddNextNum(list, node, diffff, nextNumNode.Index + 1, dict, listMin);
                            list = new List<int>(preList);
                        }

                        nextCount--;
                    }
                }


            }



        }

        private List<int> AddNum(int num, int count)
        {
            List<int> arr = new List<int>();
            for (int i = 0; i < count; i++)
            {
                arr.Add(num);
            }
            return arr;
        }

        class NumNode
        {
            public int Value;
            public int Count;
            public int Remainder;
            public int Index;
            public List<IList<int>> List = new List<IList<int>>();
            public override string ToString()
            {
                return $"value:{Value} index:{Index} list:{List.Count}";
            }
        }


        private void AddNumList(int num, int count, List<int> arr)
        {
            for (int i = 0; i < count; i++)
            {
                arr.Add(num);
            }
        }

    }
}
