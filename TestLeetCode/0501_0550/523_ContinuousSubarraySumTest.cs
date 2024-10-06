using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _523_ContinuousSubarraySumTest
    {
        _523_ContinuousSubarraySumAlg alg = new _523_ContinuousSubarraySumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [23, 2, 4, 6, 7];
            int k = 6;
            bool exp = true;
            bool res = alg.CheckSubarraySum(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [23, 2, 6, 4, 7];
            int k = 6;
            bool exp = true;
            bool res = alg.CheckSubarraySum(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [23, 2, 6, 4, 7];
            int k = 13;
            bool exp = false;
            bool res = alg.CheckSubarraySum(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
