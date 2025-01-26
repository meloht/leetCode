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
            for (int i = nextIndex; i < listDict.Count; i++)
            {
                int nextNum = listDict[i];

                if (nextNum > diff)
                {
                    break;
                }
                else if (diff == nextNum)
                {
                    var listRes = new List<int>(preList);
                    listRes.Add(nextNum);
                    res.Add(listRes);
                    break;
                }
                else
                {
                    int count = dict[nextNum];
                    int ress = diff % nextNum;
                    int nextCount = diff / nextNum;

                    if (ress == 0 && count >= nextCount)
                    {
                        var listRes = new List<int>(preList);
                        AddNumList(nextNum, nextCount, listRes);
                        res.Add(listRes);
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
                            var list = new List<int>(preList);
                            AddNumList(nextNum, count, list);
                            AddNextNum(list, res, diffff, i + 1, listDict, dict);
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


        public IList<IList<int>> CombinationSum23(int[] candidates, int target)
        {
            Array.Sort(candidates);
            IList<IList<int>> result = new List<IList<int>>();
            Backtrack(candidates, target, 0, new List<int>(), result);
            return result;
        }

        private void Backtrack(int[] candidates, int target, int start, List<int> path, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(path));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                // 跳过同一层中的重复元素
                if (i > start && candidates[i] == candidates[i - 1])
                {
                    continue;
                }
                // 剪枝：当前元素已大于剩余目标值
                if (candidates[i] > target)
                {
                    break;
                }
                path.Add(candidates[i]);
                Backtrack(candidates, target - candidates[i], i + 1, path, result);
                path.RemoveAt(path.Count - 1);
            }
        }


        private List<KeyValuePair<int, int>> freq = new List<KeyValuePair<int, int>>();
        private List<IList<int>> ans = new List<IList<int>>();
        private List<int> sequence = new List<int>();

        private void Dfs(int pos, int rest)
        {
            if (rest == 0)
            {
                ans.Add(new List<int>(sequence));
                return;
            }
            if (pos == freq.Count || rest < freq[pos].Key)
            {
                return;
            }

            Dfs(pos + 1, rest);

            int most = Math.Min(rest / freq[pos].Key, freq[pos].Value);
            for (int i = 1; i <= most; ++i)
            {
                sequence.Add(freq[pos].Key);
                Dfs(pos + 1, rest - i * freq[pos].Key);
            }
            for (int i = 1; i <= most; ++i)
            {
                sequence.RemoveAt(sequence.Count - 1);
            }
        }

        public IList<IList<int>> CombinationSum222(int[] candidates, int target)
        {
            Array.Sort(candidates);
            foreach (int num in candidates)
            {
                if (freq.Count == 0 || num != freq[freq.Count - 1].Key)
                {
                    freq.Add(new KeyValuePair<int, int>(num, 1));
                }
                else
                {
                    freq[freq.Count - 1] = new KeyValuePair<int, int>(num, freq[freq.Count - 1].Value + 1);
                }
            }
            Dfs(0, target);
            return ans;
        }



    }
}
