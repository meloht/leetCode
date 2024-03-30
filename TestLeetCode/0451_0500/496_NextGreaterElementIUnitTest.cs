using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _496_NextGreaterElementIUnitTest
    {
        _496_NextGreaterElementIAlg alg = new _496_NextGreaterElementIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = [4, 1, 2];
            int[] nums2 = [1, 3, 4, 2];
            int[] exp = [-1, 3, -1];
            int[] res = alg.NextGreaterElement(nums1, nums2);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = [2, 4];
            int[] nums2 = [1, 2, 3, 4];
            int[] exp = [3, -1];
            int[] res = alg.NextGreaterElement(nums1, nums2);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums1 = [1, 3, 5, 2, 4];
            int[] nums2 = [6, 5, 4, 3, 2, 1, 7];
            int[] exp = [7, 7, 7, 7, 7];
            int[] res = alg.NextGreaterElement(nums1, nums2);
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
