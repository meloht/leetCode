using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0962_MaximumWidthRampTest
    {
        _0962_MaximumWidthRampAlg alg = new _0962_MaximumWidthRampAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [6, 0, 8, 2, 1, 5];
            int exp = 4;
            int res = alg.MaxWidthRamp(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [9, 8, 1, 0, 1, 9, 4, 0, 4, 1];
            int exp = 7;
            int res = alg.MaxWidthRamp(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] nums = [2, 2, 1];
            int exp = 1;
            int res = alg.MaxWidthRamp(nums);
            Assert.Equal(exp, res);
        }
    }
}
