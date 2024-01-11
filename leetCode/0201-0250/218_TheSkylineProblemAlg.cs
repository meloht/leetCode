using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace leetCode._0201_0250
{
    public class _218_TheSkylineProblemAlg
    {


        public IList<IList<int>> GetSkyline1(int[][] buildings)
        {
            List<IList<int>> res = new List<IList<int>>();
            HashSet<int> set = new HashSet<int>();

            Dictionary<int, List<int[]>> dictLeft = new Dictionary<int, List<int[]>>();
            foreach (int[] item in buildings)
            {
                if (dictLeft.ContainsKey(item[0]))
                {
                    dictLeft[item[0]].Add(item);
                }
                else
                {
                    var ls = new List<int[]>();
                    ls.Add(item);
                    dictLeft.Add(item[0], ls);
                }
                set.Add(item[0]);
                set.Add(item[1]);
            }

            List<int> listSet = set.ToList();
            listSet.Sort();
            List<int[]> list = new List<int[]>();
            Dictionary<int, int> dictMax = new Dictionary<int, int>();
            for (int i = 0; i < listSet.Count; i++)
            {
                int num = listSet[i];
                list = list.Where(p => p[0] <= num && p[1] > num).ToList();
                if (dictLeft.ContainsKey(num))
                {
                    var ls = dictLeft[num];
                    list.AddRange(ls);
                }
                int max = 0;
                if (list.Count > 0)
                {
                    max = list.Max(p => p[2]);
                }

                dictMax.Add(num, max);
            }

            res.Add(new int[] { listSet[0], dictMax[listSet[0]] });
            for (int i = 1; i < listSet.Count; i++)
            {
                int prev = listSet[i - 1];
                int prevH = dictMax[prev];

                int curr = listSet[i];
                int currH = dictMax[curr];
                if (currH != prevH)
                {
                    res.Add(new int[] { curr, currH });
                }
            }

            return res;
        }


        public IList<IList<int>> GetSkyline2(int[][] buildings)
        {
            List<IList<int>> res = new List<IList<int>>();
            HashSet<int> set = new HashSet<int>();

            Dictionary<int, List<int[]>> dictLeft = new Dictionary<int, List<int[]>>();
            foreach (int[] item in buildings)
            {
                if (dictLeft.ContainsKey(item[0]))
                {
                    dictLeft[item[0]].Add(item);
                }
                else
                {
                    var ls = new List<int[]>();
                    ls.Add(item);
                    dictLeft.Add(item[0], ls);
                }
                set.Add(item[0]);
                set.Add(item[1]);
            }

            List<int> listSet = set.ToList();
            listSet.Sort();
            List<int[]> list = new List<int[]>();
            int preMax = 0;
            for (int i = 0; i < listSet.Count; i++)
            {
                int max = 0;
                int num = listSet[i];

                List<int[]> list1 = new List<int[]>();
                foreach (int[] item in list)
                {
                    if (item[0] <= num && item[1] > num)
                    {
                        max = Math.Max(max, item[2]);
                        list1.Add(item);
                    }
                }
                if (dictLeft.ContainsKey(num))
                {
                    var ls = dictLeft[num];
                    foreach (int[] item in ls)
                    {
                        if (item[0] <= num && item[1] > num)
                        {
                            max = Math.Max(max, item[2]);
                            list1.Add(item);
                        }
                    }

                }
                list = list1;
                if (i == 0)
                {
                    res.Add(new int[] { num, max });
                    preMax = max;
                }
                else
                {
                    if (max != preMax)
                    {
                        res.Add(new int[] { num, max });
                    }
                    preMax = max;
                }
            }

            return res;
        }


        public IList<IList<int>> GetSkyline3(int[][] buildings)
        {
            var xAxis = new int[buildings.Length * 2];
            for (int i = 0, j = 0; i < buildings.Length; i++)
            {
                xAxis[j++] = buildings[i][0];
                xAxis[j++] = buildings[i][1];
            }
            Array.Sort(xAxis);

            var result = new List<IList<int>>();

            var currentBuildings = new PriorityQueue<int[], int>(Comparer<int>.Create((a, b) => b - a));
            var id = 0;
            // 每一个X点（起点或者重点）进行结算
            foreach (var x in xAxis)
            {
                // 将已经越界的building出队
                // *队列按照Height从高到低排序，所以会存在Left（building[id][1]）已经越界但是未弹出的情况
                // *但是由于其并非最高高度，并不影响最高高度计算
                while (currentBuildings.Count > 0 && currentBuildings.Peek()[1] <= x)
                    currentBuildings.Dequeue();

                // 将所有正在入界的building入队（可能有多个building位于同一起点）
                // 由于X点包含了所有的起点，所以每个building必定会入队
                // 由于building[]非递减排序，所以可以用id来避免重复入队
                for (; id < buildings.Length && buildings[id][0] == x; id++)
                    currentBuildings.Enqueue(buildings[id], buildings[id][2]);

                // 获取变化后的Height，如果发生变化则记录
                var newHeight = currentBuildings.Count == 0 ? 0 : currentBuildings.Peek()[2];
                if (result.Count == 0 || newHeight != result[^1][1])
                    result.Add(new int[] { x, newHeight });
            }
            return result;
        }

        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            PriorityQueue<int[], int> queue = new PriorityQueue<int[], int>(Comparer<int>.Create((a, b) => b - a));
            List<int> list = new List<int>();
            foreach (int[] item in buildings)
            {
                list.Add(item[0]);
                list.Add(item[1]);
            }
            list.Sort();
            var result = new List<IList<int>>();
            int n = buildings.Length;
            int idx = 0;
            foreach (int item in list)
            {
                while (idx < n && buildings[idx][0] <= item)
                {
                    queue.Enqueue(new int[] { buildings[idx][1], buildings[idx][2] }, buildings[idx][2]);
                    idx++;
                }
                while (queue.Count > 0 && queue.Peek()[0] <= item)
                {
                    var dd = queue.Dequeue();
                }
                int maxn = queue.Count == 0 ? 0 : queue.Peek()[1];
                if (result.Count == 0 || maxn != result[result.Count - 1][1])
                {
                    result.Add(new int[] { item, maxn });
                }
            }
            return result;
        }




    }
}
