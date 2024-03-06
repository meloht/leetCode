using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _350_IntersectionOfTwoArraysIIUnitTest
    {
        _350_IntersectionOfTwoArraysIIAlg alg = new _350_IntersectionOfTwoArraysIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = [1, 2, 2, 1], nums2 = [2, 2];
            int[] exp = [2, 2];
            int[] res = alg.Intersect(nums1, nums2);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4];
            int[] exp = [4, 9];
            int[] res = alg.Intersect(nums1, nums2);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
