using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _718_MaximumLengthOfRepeatedSubarrayTest
    {
        _718_MaximumLengthOfRepeatedSubarrayAlg alg = new _718_MaximumLengthOfRepeatedSubarrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = [1, 2, 3, 2, 1], nums2 = [3, 2, 1, 4, 7];
            int exp = 3;
            int res = alg.FindLength(nums1, nums2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = [0, 0, 0, 0, 0], nums2 = [0, 0, 0, 0, 0];
            int exp = 5;
            int res = alg.FindLength(nums1, nums2);
            Assert.AreEqual(exp, res);
        }
    }
}
