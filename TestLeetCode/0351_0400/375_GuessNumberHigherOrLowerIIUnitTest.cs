using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _375_GuessNumberHigherOrLowerIIUnitTest
    {
        _375_GuessNumberHigherOrLowerIIAlg alg = new _375_GuessNumberHigherOrLowerIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 10;
            int exp = 16;
            int res = alg.GetMoneyAmount(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            int exp = 0;
            int res = alg.GetMoneyAmount(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 2;
            int exp = 1;
            int res = alg.GetMoneyAmount(n);
            Assert.AreEqual(exp, res);
        }
    }
}
