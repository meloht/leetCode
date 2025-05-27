
using leetCode._2851_2900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2851_2900
{
    public class _2894_DivisibleAndNonDivisibleSumsDifferenceTest
    {
        _2894_DivisibleAndNonDivisibleSumsDifferenceAlg alg = new _2894_DivisibleAndNonDivisibleSumsDifferenceAlg();

        [Fact]
        public void Test01()
        {
            int n = 10, m = 3;
            int exp = 19;
            int res = alg.DifferenceOfSums(n, m);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int n = 5, m = 6;
            int exp = 15;
            int res = alg.DifferenceOfSums(n, m);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int n = 5, m = 1;
            int exp = -15;
            int res = alg.DifferenceOfSums(n, m);
            Assert.Equal(exp, res);
        }
    }
}
