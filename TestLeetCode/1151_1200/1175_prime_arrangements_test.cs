using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1151_1200
{
    [TestClass]
    public class _1175_prime_arrangements_test
    {
        _1175_prime_arrangements alg = new _1175_prime_arrangements();

        [TestMethod]
        public void TestCase01()
        {
            int n = 5;
            int exp = 12;
            int res = alg.NumPrimeArrangements(n);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 100;
            int exp = 682289015;
            int res = alg.NumPrimeArrangements(n);
            Assert.AreEqual(exp, res);

        }
    }
}
