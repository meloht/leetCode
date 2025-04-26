using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _930_BinarySubarraysWithSumTest
    {
        _930_BinarySubarraysWithSumAlg alg = new _930_BinarySubarraysWithSumAlg();


        [Fact]
        public void Test01()
        {
            int[] nums = [1, 0, 1, 0, 1];
            int goal = 2;
            int exp = 4;
            int res = alg.NumSubarraysWithSum(nums, goal);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [0, 0, 0, 0, 0];
            int goal = 0;
            int exp = 15;
            int res = alg.NumSubarraysWithSum(nums, goal);
            Assert.Equal(exp, res);
        }

    }
}
