using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _633_SumOfSquareNumbersTest
    {
        _633_SumOfSquareNumbersAlg alg = new _633_SumOfSquareNumbersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int c = 5;
            bool exp = true;
            bool res = alg.JudgeSquareSum(c);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int c = 3;
            bool exp = false;
            bool res = alg.JudgeSquareSum(c);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int c = 4;
            bool exp = true;
            bool res = alg.JudgeSquareSum(c);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int c = 2147483646;
            bool exp = false;
            bool res = alg.JudgeSquareSum(c);
            Assert.AreEqual(exp, res);
        }
    }
}
