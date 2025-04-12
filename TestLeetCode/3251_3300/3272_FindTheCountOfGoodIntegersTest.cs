using leetCode._3251_3300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3251_3300
{
    [TestClass]
    public class _3272_FindTheCountOfGoodIntegersTest
    {
        _3272_FindTheCountOfGoodIntegersAlg alg = new _3272_FindTheCountOfGoodIntegersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3, k = 5;
            int exp = 27;
            long res = alg.CountGoodIntegers(n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1, k = 4;
            int exp = 2;
            long res = alg.CountGoodIntegers(n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 5, k = 6;
            int exp = 2468;
            long res = alg.CountGoodIntegers(n, k);
            Assert.AreEqual(exp, res);
        }
    }
}
