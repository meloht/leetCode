using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0991_BrokenCalculatorTest
    {
        _0991_BrokenCalculatorAlg alg = new _0991_BrokenCalculatorAlg();

        [Fact]
        public void Test01()
        {
            int startValue = 2, target = 3;
            int exp = 2;
            int res = alg.BrokenCalc(startValue, target);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int startValue = 5, target = 8;
            int exp = 2;
            int res = alg.BrokenCalc(startValue, target);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int startValue = 3, target = 10;
            int exp = 3;
            int res = alg.BrokenCalc(startValue, target);
            Assert.Equal(exp, res);
        }
    }
}
