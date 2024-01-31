using leetCode._1501_1550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._1501_1550
{
    [TestClass]
    public class _1512_NumberOfGoodPairsUnitTest
    {
        _1512_NumberOfGoodPairsAlg alg = new _1512_NumberOfGoodPairsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 1, 1, 3];
            int exp = 4;
            int res = alg.NumIdenticalPairs(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 1, 1, 1];
            int exp = 6;
            int res = alg.NumIdenticalPairs(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 3];
            int exp = 0;
            int res = alg.NumIdenticalPairs(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
