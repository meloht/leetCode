using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _915_PartitionArrayIntoDisjointIntervalsTest
    {
        _915_PartitionArrayIntoDisjointIntervalsAlg alg = new _915_PartitionArrayIntoDisjointIntervalsAlg();
        
        [Fact]
        public void Test01()
        {
            int[] nums = [5, 0, 3, 8, 6];
            int exp = 3;
            int res = alg.PartitionDisjoint(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [1, 1, 1, 0, 6, 12];
            int exp = 4;
            int res = alg.PartitionDisjoint(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] nums = [1, 1];
            int exp = 1;
            int res = alg.PartitionDisjoint(nums);
            Assert.Equal(exp, res);
        }
    }
}
