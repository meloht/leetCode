using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static leetCode._1101_1150._1146_SnapshotArrayAlg;

namespace leetCode._1101_1150
{
    public class _1146_SnapshotArrayAlg
    {
        public class SnapshotArray1
        {
            List<int>[] list;
            int snapId = 0;
            public SnapshotArray1(int length)
            {
                list = new List<int>[length];
                for (int i = 0; i < length; i++)
                {
                    list[i] = new List<int>();
                    list[i].Add(0);
                }

            }

            public void Set(int index, int val)
            {
                if (list[index] == null)
                {
                    list[index] = new List<int>();
                }
                while (list[index].Count <= snapId)
                {
                    list[index].Add(list[index].Last());
                }
                list[index][list[index].Count - 1] = val;
            }

            public int Snap()
            {
                return snapId++;
            }

            public int Get(int index, int snap_id)
            {
                List<int> item = list[index];

                if (item.Count <= snap_id)
                {
                    return item.Last();
                }
                else
                {
                    return item[snap_id];
                }
            }
        }


        public class SnapshotArray
        {

            List<SortedList<int, int>> list = new List<SortedList<int, int>>();
            int snapId = 0;
            public SnapshotArray(int length)
            {
                for (int i = 0; i < length; i++)
                {
                    list.Add(new SortedList<int, int>());
                    list[i].Add(snapId, 0);
                }

            }

            public void Set(int index, int val)
            {
                var item = list[index];
                if (item.ContainsKey(snapId))
                {
                    item[snapId] = val;
                }
                else
                {
                    item.Add(snapId, val);
                }

            }

            public int Snap()
            {
                return snapId++;
            }

            public int Get(int index, int snap_id)
            {
                var item = list[index];

                if (item.ContainsKey(snap_id))
                {
                    return item[snap_id];
                }

                var nums = item.FirstOrDefault(p => p.Key < snap_id);
                
                return nums.Value;
            }
        }
    }
}
