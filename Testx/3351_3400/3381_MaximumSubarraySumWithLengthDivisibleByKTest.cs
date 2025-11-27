using leetCode._3351_3400;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3351_3400
{
    public class _3381_MaximumSubarraySumWithLengthDivisibleByKTest
    {
        _3381_MaximumSubarraySumWithLengthDivisibleByKAlg alg = new _3381_MaximumSubarraySumWithLengthDivisibleByKAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [1, 2];
            int k = 1;
            long exp = 3;
            long res = alg.MaxSubarraySum(nums, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [-1, -2, -3, -4, -5];
            int k = 4;
            long exp = -10;
            long res = alg.MaxSubarraySum(nums, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] nums = [-5, 1, 2, -3, 4];
            int k = 2;
            long exp = 4;
            long res = alg.MaxSubarraySum(nums, k);
            Assert.Equal(exp, res);
        }
    }
}
