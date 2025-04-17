using leetCode._2101_2150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2151_2200
{
    public class _2176_CountEqualAndDivisiblePairsInAnArrayTest
    {
        _2176_CountEqualAndDivisiblePairsInAnArrayAlg alg = new _2176_CountEqualAndDivisiblePairsInAnArrayAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [3, 1, 2, 2, 2, 1, 3];
            int k = 2;
            int exp = 4;
            int res= alg.CountPairs(nums, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [1, 2, 3, 4];
            int k = 1;
            int exp = 0;
            int res = alg.CountPairs(nums, k);
            Assert.Equal(exp, res);
        }
    }
}
