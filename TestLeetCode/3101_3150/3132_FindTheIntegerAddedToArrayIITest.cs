using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3132_FindTheIntegerAddedToArrayIITest
    {
        _3132_FindTheIntegerAddedToArrayIIAlg alg = new _3132_FindTheIntegerAddedToArrayIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = [4, 20, 16, 12, 8], nums2 = [14, 18, 10];
            int exp = -2;
            int res = alg.MinimumAddedInteger(nums1, nums2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = [3, 5, 5, 3], nums2 = [7, 7];
            int exp = 2;
            int res = alg.MinimumAddedInteger(nums1, nums2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums1 = [3, 5, 5, 3], nums2 = [7, 7];
            int exp = 2;
            int res = alg.MinimumAddedInteger(nums1, nums2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums1 = [10, 2, 8, 7, 5, 6, 7, 10], nums2 = [5, 8, 5, 3, 8, 4];
            int exp = -2;
            int res = alg.MinimumAddedInteger(nums1, nums2);
            Assert.AreEqual(exp, res);
        }
    }
}
