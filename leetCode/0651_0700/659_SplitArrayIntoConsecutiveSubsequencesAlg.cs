using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _659_SplitArrayIntoConsecutiveSubsequencesAlg
    {
        public bool IsPossible1(int[] nums)
        {
            Dictionary<int, int> countDict = new Dictionary<int, int>();

            Dictionary<int, int> endDict = new Dictionary<int, int>();

            foreach (int x in nums)
            {
                if (countDict.ContainsKey(x))
                {
                    countDict[x]++;
                }
                else
                {
                    countDict.Add(x, 1);
                }
            }

            foreach (int x in nums)
            {
                int count = countDict.GetValueOrDefault(x, 0);
                if (count > 0)
                {
                    int prevEnd = endDict.GetValueOrDefault(x - 1, 0);
                    if (prevEnd > 0)
                    {
                        countDict[x]--;
                        endDict[x - 1]--;
                        if (endDict.ContainsKey(x))
                        {
                            endDict[x]++;
                        }
                        else
                        {
                            endDict.Add(x, 1);
                        }
                    }
                    else
                    {
                        int count1 = countDict.GetValueOrDefault(x + 1, 0);
                        int count2 = countDict.GetValueOrDefault(x + 2, 0);
                        if (count1 > 0 && count2 > 0)
                        {
                            countDict[x]--;
                            countDict[x + 1]--;
                            countDict[x + 2]--;

                            if (endDict.ContainsKey(x + 2))
                            {
                                endDict[x + 2]++;
                            }
                            else
                            {
                                endDict.Add(x + 2, 1);
                            }
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
            }

            return true;
        }

        public bool IsPossible(int[] nums)
        {
            Dictionary<int, PriorityQueue<int, int>> dict = new Dictionary<int, PriorityQueue<int, int>>();
            foreach (int x in nums)
            {
                if (!dict.ContainsKey(x))
                {
                    dict.Add(x, new PriorityQueue<int, int>());
                }
                if (dict.ContainsKey(x - 1))
                {
                    int prevLen = dict[x - 1].Dequeue();
                    if (dict[x - 1].Count == 0)
                    {
                        dict.Remove(x - 1);
                    }
                    dict[x].Enqueue(prevLen + 1, prevLen + 1);

                }
                else
                {
                    dict[x].Enqueue(1, 1);
                }
            }

            foreach (var item in dict)
            {
                var queue = item.Value;
                if (queue.Peek() < 3)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
