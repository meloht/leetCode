using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0701_0750
{
    [TestClass]
    public class _740_DeleteAndEarnUnitTest
    {
        _740_DeleteAndEarnAlg alg = new _740_DeleteAndEarnAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 4, 2];
            int exp = 6;
            int res = alg.DeleteAndEarn(nums);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 2, 3, 3, 3, 4];
            int exp = 9;
            int res = alg.DeleteAndEarn(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [8, 3, 4, 7, 6, 6, 9, 2, 5, 8, 2, 4, 9, 5, 9, 1, 5, 7, 1, 4];
            int exp = 61;
            int res = alg.DeleteAndEarn(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [3, 7, 10, 5, 2, 4, 8, 9, 9, 4, 9, 2, 6, 4, 6, 5, 4, 7, 6, 10];
            int exp = 66;
            int res = alg.DeleteAndEarn(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
