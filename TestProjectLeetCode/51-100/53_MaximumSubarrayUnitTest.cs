using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _53_MaximumSubarrayUnitTest
    {
        _53_MaximumSubarrayAlg alg;

        [TestInitialize]
        public void Init()
        {
            alg = new _53_MaximumSubarrayAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var res = alg.MaxSubArray(nums);
            Assert.AreEqual(6, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[] nums = { 1 };
            var res = alg.MaxSubArray(nums);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = { 5, 4, -1, 7, 8 };
            var res = alg.MaxSubArray(nums);
            Assert.AreEqual(23, res);
        }
    }
}
