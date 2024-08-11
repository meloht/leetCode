using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1035_UncrossedLinesTest
    {
        _1035_UncrossedLinesAlg alg = new _1035_UncrossedLinesAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = [1, 4, 2], nums2 = [1, 2, 4];
            int exp = 2;
            int res = alg.MaxUncrossedLines(nums1, nums2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = [2, 5, 1, 2, 5], nums2 = [10, 5, 2, 1, 5, 2];
            int exp = 3;
            int res = alg.MaxUncrossedLines(nums1, nums2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums1 = [1, 3, 7, 1, 7, 5], nums2 = [1, 9, 2, 5, 1];
            int exp = 2;
            int res = alg.MaxUncrossedLines(nums1, nums2);
            Assert.AreEqual(exp, res);
        }
    }
}
