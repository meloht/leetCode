using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetCode._1_50
{
    public class _40_CombinationSumIIAlg
    {


        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();

            List<int> listNums = new List<int>();
            HashSet<int> setInt = new HashSet<int>();
            foreach (var item in candidates)
            {
                if (item == target)
                {
                    if (!setInt.Contains(item))
                    {
                        setInt.Add(item);
                        res.Add(new List<int>() { item });
                    }
                }
                if (item < target)
                {
                    listNums.Add(item);
                }
            }
            if (listNums.Count == 0)
            {
                return res;
            }
            listNums.Sort();

            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            List<int> listDict = new List<int>();
            foreach (var item in listNums)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, new List<int>());
                    listDict.Add(item);
                }
                dict[item].Add(item);
            }

            int i = 0;

            foreach (var item in dict)
            {
                int sum = listDict[i];
                List<int> current = new List<int>();
                current.Add(listDict[i]);

                int diff = target - sum;

                AddNextNum(listDict, res, current, diff, i + 1, dict);

                i++;
            }



            return res;

        }


        private void AddNextNum(List<int> listNums, IList<IList<int>> res, List<int> current, int diff, int nextIndex, Dictionary<int, List<int>> dict)
        {
            List<int> list = new List<int>(current);

            for (int i = nextIndex; i < listNums.Count; i++)
            {
                int nextNum = listNums[i];

                if (nextNum > diff)
                {
                    return;
                }
                else if (diff == nextNum)
                {
                    list.Add(nextNum);
                    res.Add(list);
                    list = new List<int>(current);
                    return;

                }
                else
                {
                    List<int> chlist = new List<int>(dict[i]);
                    if (chlist.Count > 1)
                    {
                        chlist.RemoveAt(0);
                    }

                    //int ress = diff % nextNum;
                    //int nextCount = diff / nextNum;
                    //if (ress == 0)
                    //{
                    //    AddNumList(nextNum, nextCount, list);
                    //   // node.List.Add(list);
                    //    list = new List<int>(preList);
                    //    nextCount--;
                    //}
                    //while (nextCount > 0)
                    //{
                    //    int diffff = diff - nextNum * nextCount;

                    //    if (diffff > nextNum)
                    //    {
                    //        AddNumList(nextNum, nextCount, list);
                    //        AddNextNum(list, node, diffff, nextNumNode.Index + 1, dict, listMin);
                    //        list = new List<int>(preList);
                    //    }

                    //    nextCount--;
                    //}


                    list.Add(nextNum);
                    int diffff = diff - nextNum;
                    AddNextNum(listNums, res, list, diffff, i + 1, dict);
                    list = new List<int>(current);

                }
            }
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


        public IList<IList<int>> CombinationSum21(int[] candidates, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();

            List<int> listNums = new List<int>();

            foreach (var item in candidates)
            {
                if (item <= target)
                {
                    listNums.Add(item);
                }
            }
            listNums.Sort();

            if (listNums.Count == 0)
            {
                return res;
            }
            bool[] used = new bool[listNums.Count];
            List<int> current = new List<int>();
            Permute(listNums, current, res, used, target);
            return res;

        }

        private void Permute(List<int> listNums, List<int> current, IList<IList<int>> result, bool[] used, int target)
        {
            int sum = current.Sum();
            if (sum == target)
            {
                bool bl = IsSame(result, current);
                if (bl == false)
                {
                    result.Add(new List<int>(current));
                }

                return;
            }
            if (sum > target)
            {
                return;
            }

            for (int i = 0; i < listNums.Count; i++)
            {
                if (used[i])
                {
                    continue;
                }

                current.Add(listNums[i]);


                used[i] = true;
                Permute(listNums, current, result, used, target);
                used[i] = false;
                current.Clear();

            }
        }


        private void Print(List<int> nums)
        {
            System.Diagnostics.Debug.WriteLine("");
            foreach (var item in nums)
            {
                System.Diagnostics.Debug.Write(item + ",");
            }
        }
        private bool IsSame(IList<IList<int>> result, List<int> current)
        {
            if (result.Count == 0)
                return false;

            var data = result.Where(p => p.Count == current.Count).ToList();
            foreach (var item in data)
            {
                int count = 0;
                foreach (var item2 in item)
                {
                    if (current.Contains(item2))
                    {
                        count++;
                    }
                }
                if (count == current.Count)
                {
                    return true;
                }
            }
            return false;

        }

    }
}
