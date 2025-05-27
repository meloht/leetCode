using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0974_SubarraySumsDivisibleByKTest
    {
        _0974_SubarraySumsDivisibleByKAlg alg = new _0974_SubarraySumsDivisibleByKAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [4, 5, 0, -2, -3, 1];
            int k = 5;
            int exp = 7;
            int res = alg.SubarraysDivByK(nums, k);
            Assert.Equal(exp, res);
        }
        [Fact]
        public void Test02()
        {
            int[] nums = [5];
            int k = 9;
            int exp = 0;
            int res = alg.SubarraysDivByK(nums, k);
            Assert.Equal(exp, res);
        }
    }
}
