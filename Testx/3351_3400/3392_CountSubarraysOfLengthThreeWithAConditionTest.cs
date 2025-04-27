using leetCode._3351_3400;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3351_3400
{
    public class _3392_CountSubarraysOfLengthThreeWithAConditionTest
    {
        _3392_CountSubarraysOfLengthThreeWithAConditionAlg alg = new _3392_CountSubarraysOfLengthThreeWithAConditionAlg();
        [Fact]
        public void Test01()
        {
            int[] nums = [1, 2, 1, 4, 1];
            int exp = 1;
            int res = alg.CountSubarrays(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [1, 1, 1];
            int exp = 0;
            int res = alg.CountSubarrays(nums);
            Assert.Equal(exp, res);
        }
    }
}
