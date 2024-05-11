using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _352_DataStreamAsDisjointIntervalsAlg
    {
        public class SummaryRanges
        {
            List<int[]> list = new List<int[]>();
            public SummaryRanges()
            {

            }

            public void AddNum(int value)
            {
                if (list.Count == 0)
                {
                    list.Add([value, value]);
                }
                else if (list.Count == 1)
                {
                    if (list[0][1] >= value - 1 && list[0][1] <= value + 1)
                    {
                        list[0][1] = Math.Max(value, list[0][1]);
                        list[0][0] = Math.Min(value, list[0][0]);
                    }
                    else
                    {
                        if (list[0][1] < value - 1)
                        {
                            list.Add([value, value]);
                        }
                        else if (list[0][0] > value + 1)
                        {
                            list.Insert(0, [value, value]);
                        }
                    }


                }
                else
                {
                    BinarySearch(value);
                }
            }

            public int[][] GetIntervals()
            {
                return list.ToArray();
            }

            private void BinarySearch(int target)
            {
                int left = 0;
                int right = list.Count - 1;

                while (left <= right)
                {
                    int mid = (right - left) / 2 + left;

                    int max = list[mid][1];
                    int min = list[mid][0];

                    if (target <= max + 1 && target >= min - 1)
                    {
                        list[mid][1] = Math.Max(target, list[mid][1]);
                        list[mid][0] = Math.Min(target, list[mid][0]);
                        if (mid + 1 < list.Count)
                        {
                            if (list[mid][1] + 1 >= list[mid + 1][0])
                            {
                                list[mid][1] = list[mid + 1][1];
                                list.RemoveAt(mid + 1);
                            }
                        }
                        if (mid - 1 >= 0)
                        {
                            if (list[mid][0] <= list[mid - 1][1] + 1)
                            {
                                list[mid][0] = list[mid - 1][0];
                                list.RemoveAt(mid - 1);
                            }
                        }
                        return;
                    }
                    else if (target > max + 1)
                    {
                        if (mid + 1 < list.Count)
                        {
                            if (target < list[mid + 1][0] - 2)
                            {
                                list.Insert(mid + 1, [target, target]);
                                return;
                            }
                        }
                        left = mid + 1;
                    }
                    else if (target < min - 1)
                    {
                        if (mid - 1 >= 0)
                        {
                            if (target > list[mid - 1][1] + 1)
                            {
                                list.Insert(mid, [target, target]);
                                return;
                            }
                        }
                        right = mid - 1;
                    }

                }
                if (left >= list.Count - 1)
                {
                    list.Add([target, target]);
                }
                else
                {
                    list.Insert(0, [target, target]);
                }


            }
        }
    }
}
