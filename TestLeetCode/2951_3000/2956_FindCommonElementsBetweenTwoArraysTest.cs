using leetCode._2951_3000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2951_3000
{
    [TestClass]
    public class _2956_FindCommonElementsBetweenTwoArraysTest
    {
        _2956_FindCommonElementsBetweenTwoArraysAlg alg = new _2956_FindCommonElementsBetweenTwoArraysAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = [2, 3, 2], nums2 = [1, 2];
            int[] exp = [2, 1];
            int[] res = alg.FindIntersectionValues(nums1, nums2);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = [4, 3, 2, 3, 1], nums2 = [2, 2, 5, 2, 3, 6];
            int[] exp = [3, 4];
            int[] res = alg.FindIntersectionValues(nums1, nums2);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums1 = [3, 4, 2, 3], nums2 = [1, 5];
            int[] exp = [0, 0];
            int[] res = alg.FindIntersectionValues(nums1, nums2);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
