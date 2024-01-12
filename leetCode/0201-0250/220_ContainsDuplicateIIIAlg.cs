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
            int len = ls.Count;
            for (int i = 0; i < len; i++)
            {
                var curr = ls[i];

                for (int j = i + 1; j < len; j++)
                {
                    var next = ls[j];
                    int diff = Math.Abs(curr.Value - next.Value);
                    if (diff > valueDiff)
                        break;
                    int indff = Math.Abs(curr.Index - next.Index);
                    if (indff <= indexDiff)
                        return true;
                }
            }

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
