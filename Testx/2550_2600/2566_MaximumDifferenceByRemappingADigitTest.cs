using leetCode._2551_2600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2550_2600
{
    public class _2566_MaximumDifferenceByRemappingADigitTest
    {
        _2566_MaximumDifferenceByRemappingADigitAlg alg = new _2566_MaximumDifferenceByRemappingADigitAlg();

        [Fact]
        public void Test01()
        {
            int num = 11891;
            int exp = 99009;
            int res = alg.MinMaxDifference(num);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int num = 90;
            int exp = 99;
            int res = alg.MinMaxDifference(num);
            Assert.Equal(exp, res);
        }
    }
}
