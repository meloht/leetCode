using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._1001_1050
{
    [TestClass]
    public class _1012_NumbersWithRepeatedDigitsUnitTest
    {
        _1012_NumbersWithRepeatedDigitsAlg alg = new _1012_NumbersWithRepeatedDigitsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 20;
            int exp = 1;
            int res = alg.NumDupDigitsAtMostN(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 100;
            int exp = 10;
            int res = alg.NumDupDigitsAtMostN(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 1000;
            int exp = 262;
            int res = alg.NumDupDigitsAtMostN(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 1000000000;
            int exp = 994388230;
            int res = alg.NumDupDigitsAtMostN(n);
            Assert.AreEqual(exp, res);
        }
    }
}
