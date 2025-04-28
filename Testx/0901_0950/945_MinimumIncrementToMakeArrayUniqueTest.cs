using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _945_MinimumIncrementToMakeArrayUniqueTest
    {
        _945_MinimumIncrementToMakeArrayUniqueAlg alg = new _945_MinimumIncrementToMakeArrayUniqueAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [1, 2, 2];
            int exp = 1;
            int res = alg.MinIncrementForUnique(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [3, 2, 1, 2, 1, 7];
            int exp = 6;
            int res = alg.MinIncrementForUnique(nums);
            Assert.Equal(exp, res);
        }
    }
}
