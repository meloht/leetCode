using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1201_1250
{
    [TestClass]
    public class _1201_UglyNumberIIITest
    {
        _1201_UglyNumberIIIAlg alg = new _1201_UglyNumberIIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3, a = 2, b = 3, c = 5;
            int exp = 4;
            int res = alg.NthUglyNumber(n, a, b, c);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 4, a = 2, b = 3, c = 4;
            int exp = 6;
            int res = alg.NthUglyNumber(n, a, b, c);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 5, a = 2, b = 11, c = 13;
            int exp = 10;
            int res = alg.NthUglyNumber(n, a, b, c);
            Assert.AreEqual(exp, res);
        }
    }
}
