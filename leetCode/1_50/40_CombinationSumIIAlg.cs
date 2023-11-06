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
            HashSet<int> visited = new HashSet<int>();
            foreach (var item in candidates)
            {
                if (item == target)
                {
                    if (!visited.Contains(item))
                    {
                        res.Add(new List<int>() { item });
                        visited.Add(item);
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

            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> listDict = new List<int>();
            foreach (var item in listNums)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 0);
                    listDict.Add(item);
                }
                dict[item]++;

            }

            int index = 0, remainder, numCount, diff, count, sum, j;

            foreach (var item in listDict)
            {
                remainder = target % item;
                numCount = target / item;
                diff = remainder;
                count = dict[item];
                if (count >= numCount && remainder == 0 && numCount > 0)
                {
                    res.Add(AddNum(item, numCount));
                    numCount -= 2;
                }
                else
                {
                    numCount--;
                    if (count < numCount)
                    {
                        numCount = count;
                    }
                }

                sum = 0;
                j = 1;
                while (j <= numCount)
                {
                    List<int> arr = new List<int>();
                    AddNumList(item, j, arr);
                    sum = item * j;
                    diff = target - sum;
                    AddNextNum(arr, res, diff, index + 1, listDict, dict);
                    j++;
                }
                index++;
            }
            return res;
        }

        private void AddNextNum(List<int> preList, IList<IList<int>> res, int diff, int nextIndex,
            List<int> listDict, Dictionary<int, int> dict)
        {
            List<int> list = new List<int>(preList);

            for (int i = nextIndex; i < listDict.Count; i++)
            {
                int nextNum = listDict[i];

                if (nextNum > diff)
                {
                    break;
                }
                else if (diff == nextNum)
                {
                    list.Add(nextNum);
                    res.Add(list);
                    list = new List<int>(preList);
                    break;

                }
                else
                {
                    int count = dict[nextNum];
                    int ress = diff % nextNum;
                    int nextCount = diff / nextNum;
                    if (ress == 0 && count >= nextCount)
                    {
                        AddNumList(nextNum, nextCount, list);
                        res.Add(list);

                        list = new List<int>(preList);
                        nextCount--;
                    }
                    if (count >= nextCount)
                    {
                        count = nextCount;
                    }

                    while (count > 0)
                    {
                        int diffff = diff - nextNum * count;

                        if (diffff > nextNum)
                        {
                            AddNumList(nextNum, count, list);
                            AddNextNum(list, res, diffff, i + 1, listDict, dict);
                            list = new List<int>(preList);
                        }

                        count--;
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
