using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _581_ShortestUnsortedContinuousSubarrayTest
    {
        _581_ShortestUnsortedContinuousSubarrayAlg alg = new _581_ShortestUnsortedContinuousSubarrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 6, 4, 8, 10, 9, 15];
            int exp = 5;
            int res = alg.FindUnsortedSubarray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4];
            int exp = 0;
            int res = alg.FindUnsortedSubarray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1];
            int exp = 0;
            int res = alg.FindUnsortedSubarray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [1, 3, 2, 4, 5];
            int exp = 2;
            int res = alg.FindUnsortedSubarray(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
