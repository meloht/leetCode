using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1146_SnapshotArrayAlg
    {
        public class SnapshotArray
        {
            List<int[]> arr = new List<int[]>();
            int snapId = 0;
            int[] nums;

            public SnapshotArray(int length)
            {
                nums = new int[length];
            }

            public void Set(int index, int val)
            {
                nums[index] = val;
            }

            public int Snap()
            {
                int id = snapId;
                int[] nn = new int[nums.Length];
                Array.Copy(nums, nn, nums.Length);
                arr.Add(nn);

                snapId++;
                return id;
            }

            public int Get(int index, int snap_id)
            {
                int val = arr[snap_id][index];
                return val;
            }
        }
    }
}
