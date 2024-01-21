using leetCode._1701_1750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._1701_1750
{
    [TestClass]
    public class _1742_MaximumNumberOfBallsInABoxUnitTest
    {
        _1742_MaximumNumberOfBallsInABoxAlg alg = new _1742_MaximumNumberOfBallsInABoxAlg();

        [TestMethod]
        public void TestCase01()
        {
            int lowLimit = 1, highLimit = 10;
            int exp = 2;

            int res = alg.CountBalls(lowLimit,highLimit);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int lowLimit = 5, highLimit = 15;
            int exp = 2;

            int res = alg.CountBalls(lowLimit, highLimit);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int lowLimit = 19, highLimit = 28;
            int exp = 2;

            int res = alg.CountBalls(lowLimit, highLimit);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int lowLimit = 99999, highLimit = 99999;
            int exp = 1;

            int res = alg.CountBalls(lowLimit, highLimit);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase05()
        {
            int lowLimit = 11, highLimit = 104;
            int exp = 9;

            int res = alg.CountBalls(lowLimit, highLimit);
            Assert.AreEqual(exp, res);
        }
    }
}
