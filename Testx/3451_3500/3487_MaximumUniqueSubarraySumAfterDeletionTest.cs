using leetCode._3451_3500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3451_3500
{
    public class _3487_MaximumUniqueSubarraySumAfterDeletionTest
    {
        _3487_MaximumUniqueSubarraySumAfterDeletionAlg alg = new _3487_MaximumUniqueSubarraySumAfterDeletionAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [1, 2, 3, 4, 5];
            int exp = 15;
            int res = alg.MaxSum(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [1, 1, 0, 1, 1];
            int exp = 1;
            int res = alg.MaxSum(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] nums = [1, 2, -1, -2, 1, 0, -1];
            int exp = 3;
            int res = alg.MaxSum(nums);
            Assert.Equal(exp, res);
        }
    }
}
