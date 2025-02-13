using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _795_NumberOfSubarraysWithBoundedMaximumTest
    {
        _795_NumberOfSubarraysWithBoundedMaximumAlg alg = new _795_NumberOfSubarraysWithBoundedMaximumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 1, 4, 3];
            int left = 2;
            int right = 3;
            int exp = 3;
            int res = alg.NumSubarrayBoundedMax(nums, left, right);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 9, 2, 5, 6];
            int left = 2;
            int right = 8;
            int exp = 7;
            int res = alg.NumSubarrayBoundedMax(nums, left, right);
            Assert.AreEqual(exp, res);
        }
    }
}
