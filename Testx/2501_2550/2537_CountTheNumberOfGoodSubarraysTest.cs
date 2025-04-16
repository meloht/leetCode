using leetCode._2501_2550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2501_2550
{
    public class _2537_CountTheNumberOfGoodSubarraysTest
    {
        _2537_CountTheNumberOfGoodSubarraysAlg alg = new _2537_CountTheNumberOfGoodSubarraysAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [1, 1, 1, 1, 1];
            int k = 10;
            long exp = 1;
            long res = alg.CountGood(nums, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [3, 1, 4, 3, 2, 2, 4];
            int k = 2;
            long exp = 4;
            long res = alg.CountGood(nums, k);
            Assert.Equal(exp, res);
        }
    }
}
