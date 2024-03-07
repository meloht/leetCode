using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _374_GuessNumberHigherOrLowerUnitTest
    {
        _374_GuessNumberHigherOrLowerAlg alg = new _374_GuessNumberHigherOrLowerAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 10, pick = 6;
            alg.Pick=pick;
            int exp = 6;
            int res = alg.GuessNumber(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1, pick = 1;
            alg.Pick = pick;
            int exp = 1;
            int res = alg.GuessNumber(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 2, pick = 1;
            alg.Pick = pick;
            int exp = 1;
            int res = alg.GuessNumber(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 2, pick = 2;
            alg.Pick = pick;
            int exp = 2;
            int res = alg.GuessNumber(n);
            Assert.AreEqual(exp, res);
        }
    }
}
