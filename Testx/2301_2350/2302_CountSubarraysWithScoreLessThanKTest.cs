using leetCode._2301_2350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2301_2350
{
    public class _2302_CountSubarraysWithScoreLessThanKTest
    {
        _2302_CountSubarraysWithScoreLessThanKAlg alg = new _2302_CountSubarraysWithScoreLessThanKAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [2, 1, 4, 3, 5];
            int k = 10;
            long exp = 6;
            long res = alg.CountSubarrays(nums, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [2, 1, 4, 3, 5];
            int k = 10;
            long exp = 6;
            long res = alg.CountSubarrays(nums, k);
            Assert.Equal(exp, res);
        }
    }
}
