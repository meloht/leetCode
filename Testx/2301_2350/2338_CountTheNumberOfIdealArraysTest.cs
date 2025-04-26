using leetCode._2301_2350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2301_2350
{
    public class _2338_CountTheNumberOfIdealArraysTest
    {
        _2338_CountTheNumberOfIdealArraysAlg alg = new _2338_CountTheNumberOfIdealArraysAlg();
        [Fact]
        public void Test01()
        {
            int n = 2, maxValue = 5;
            int exp = 10;
            int res = alg.IdealArrays(n, maxValue);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int n = 5, maxValue = 3;
            int exp = 11;
            int res = alg.IdealArrays(n, maxValue);
            Assert.Equal(exp, res);
        }

    }
}
