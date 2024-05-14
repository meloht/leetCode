using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _372_SuperPowUnitTest
    {
        _372_SuperPowAlg alg = new _372_SuperPowAlg();


        [TestMethod]
        public void TestCase01()
        {
            int a = 2;
            int[] b = [3];
            int exp = 8;
            int res = alg.SuperPow(a, b);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int a = 2;
            int[] b = [1, 0];
            int exp = 1024;
            int res = alg.SuperPow(a, b);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int a = 1;
            int[] b = [4, 3, 3, 8, 5, 2];
            int exp = 1;
            int res = alg.SuperPow(a, b);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int a = 2147483647;
            int[] b = [2, 0, 0];
            int exp = 1198;
            int res = alg.SuperPow(a, b);
            Assert.AreEqual(exp, res);
        }
    }
}
