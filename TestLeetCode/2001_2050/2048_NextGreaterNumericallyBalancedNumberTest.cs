using leetCode._2001_2050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2001_2050
{
    [TestClass]
    public class _2048_NextGreaterNumericallyBalancedNumberTest
    {
        _2048_NextGreaterNumericallyBalancedNumberAlg alg = new _2048_NextGreaterNumericallyBalancedNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 1;
            int res = alg.NextBeautifulNumber(n);
            int exp = 22;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1000;
            int res = alg.NextBeautifulNumber(n);
            int exp = 1333;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 3000;
            int res = alg.NextBeautifulNumber(n);
            int exp = 3133;
            Assert.AreEqual(exp, res);
        }
    }
}
