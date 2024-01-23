using leetCode._2751_2800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2751_2800
{
    [TestClass]
    public class _2765_LongestAlternatingSubarrayUnitTest
    {
        _2765_LongestAlternatingSubarrayAlg alg = new _2765_LongestAlternatingSubarrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 3, 4, 3, 4];
            int exp = 4;
            int res = alg.AlternatingSubarray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [4, 5, 6];
            int exp = 2;
            int res = alg.AlternatingSubarray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 29, 30, 5];
            int exp = 2;
            int res = alg.AlternatingSubarray(nums);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [14, 30, 29, 49, 3, 23, 44, 21, 26, 52];
            int exp = -1;
            int res = alg.AlternatingSubarray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums = [8, 4, 3, 2, 6, 4, 3, 5, 2, 8];
            int exp = -1;
            int res = alg.AlternatingSubarray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            int[] nums = [8, 4, 3, 2, 6, 4, 3, 5, 2, 8];
            int exp = -1;
            int res = alg.AlternatingSubarray(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
