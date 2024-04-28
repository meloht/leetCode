using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _321_CreateMaximumNumberUnitTest
    {
        _321_CreateMaximumNumberAlg alg = new _321_CreateMaximumNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = [3, 4, 6, 5], nums2 = [9, 1, 2, 5, 8, 3];
            int k = 5;
            int[] exp = [9, 8, 6, 5, 3];
            int[] res = alg.MaxNumber(nums1, nums2, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = [6, 7], nums2 = [6, 0, 4];
            int k = 3;
            int[] exp = [6, 7, 6, 0, 4];
            int[] res = alg.MaxNumber(nums1, nums2, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums1 = [3, 9], nums2 = [8, 9];
            int k = 3;
            int[] exp = [9, 8, 9];
            int[] res = alg.MaxNumber(nums1, nums2, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
