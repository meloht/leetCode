using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _220_ContainsDuplicateIIIAlg
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
        {
            List<DataModel> list = new List<DataModel>();

            for (int i = 0; i < nums.Length; i++)
            {
                list.Add(new DataModel(nums[i], i));
            }

            var ls = list.OrderBy(p => p.Value).ToList();


            return false;

        }
        class DataModel
        {
            public int Value;
            public int Index;
            public DataModel(int val, int index)
            {
                this.Index = index;
                this.Value = val;
            }
        }
    }
}
