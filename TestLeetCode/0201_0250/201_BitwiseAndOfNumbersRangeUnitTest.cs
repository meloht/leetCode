using leetCode._201_250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._201_250
{
    [TestClass]
    public class _201_BitwiseAndOfNumbersRangeUnitTest
    {
        _201_BitwiseAndOfNumbersRangeAlg alg = new _201_BitwiseAndOfNumbersRangeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int left = 5, right = 7;
            int res = alg.RangeBitwiseAnd(left, right);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int left = 0, right = 0;
            int res = alg.RangeBitwiseAnd(left, right);
            Assert.AreEqual(0, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            int left = 1, right = 2147483647;
            int res = alg.RangeBitwiseAnd(left, right);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int left = 2147483646, right = 2147483647;
            int res = alg.RangeBitwiseAnd(left, right);
            Assert.AreEqual(2147483646, res);
        }
        [TestMethod]
        public void TestCase05()
        {
            int left = 2147483647, right = 2147483647;
            int res = alg.RangeBitwiseAnd(left, right);
            Assert.AreEqual(2147483647, res);
        }
    }
}
