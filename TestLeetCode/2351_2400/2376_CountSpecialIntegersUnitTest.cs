using leetCode._2351_2400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2351_2400
{
    [TestClass]
    public class _2376_CountSpecialIntegersUnitTest
    {
        _2376_CountSpecialIntegersAlg alg = new _2376_CountSpecialIntegersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 20;
            int exp = 19;
            int res = alg.CountSpecialNumbers(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 5;
            int exp = 5;
            int res = alg.CountSpecialNumbers(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 135;
            int exp = 110;
            int res = alg.CountSpecialNumbers(n);
            Assert.AreEqual(exp, res);
        }
    }
}
