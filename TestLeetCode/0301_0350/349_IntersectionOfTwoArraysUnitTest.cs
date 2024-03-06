using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _349_IntersectionOfTwoArraysUnitTest
    {
        _349_IntersectionOfTwoArraysAlg alg = new _349_IntersectionOfTwoArraysAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = [1, 2, 2, 1], nums2 = [2, 2];
            int[] exp = [2];
            int[] res = alg.Intersection(nums1, nums2);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4];
            int[] exp = [9, 4];
            int[] res = alg.Intersection(nums1, nums2);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
