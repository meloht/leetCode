using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1015_SmallestIntegerDivisibleByKTest
    {
        _1015_SmallestIntegerDivisibleByKAlg alg = new _1015_SmallestIntegerDivisibleByKAlg();
        [Fact]
        public void Test01()
        {
            int k = 1;
            int exp = 1;
            int res = alg.SmallestRepunitDivByK(k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int k = 2;
            int exp = -1;
            int res = alg.SmallestRepunitDivByK(k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int k = 3;
            int exp = 3;
            int res = alg.SmallestRepunitDivByK(k);
            Assert.Equal(exp, res);
        }
    }
}
