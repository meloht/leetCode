using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3131_FindTheIntegerAddedToArrayITest
    {
        _3131_FindTheIntegerAddedToArrayIAlg alg = new _3131_FindTheIntegerAddedToArrayIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = [2, 6, 4], nums2 = [9, 7, 5];
            int exp = 3;
            int res = alg.AddedInteger(nums1, nums2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = [10], nums2 = [5];
            int exp = -5;
            int res = alg.AddedInteger(nums1, nums2);
            Assert.AreEqual(exp, res);
        }
    }
}
