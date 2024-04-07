using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _313_SuperUglyNumberUnitTest
    {
        _313_SuperUglyNumberAlg alg = new _313_SuperUglyNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 12;
            int[] primes = [2, 7, 13, 19];
            int exp = 32;
            int res = alg.NthSuperUglyNumber(n, primes);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            int[] primes = [2, 3, 5];
            int exp = 1;
            int res = alg.NthSuperUglyNumber(n, primes);
            Assert.AreEqual(exp, res);
        }
    }
}
