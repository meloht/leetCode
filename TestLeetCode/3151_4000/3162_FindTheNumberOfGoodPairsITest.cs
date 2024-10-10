using leetCode._3151_4000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_4000
{
    [TestClass]
    public class _3162_FindTheNumberOfGoodPairsITest
    {
        _3162_FindTheNumberOfGoodPairsIAlg alg = new _3162_FindTheNumberOfGoodPairsIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = [1, 3, 4], nums2 = [1, 3, 4];
            int k = 1;
            int exp = 5;
            int res = alg.NumberOfPairs(nums1, nums2, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = [1, 2, 4, 12], nums2 = [2, 4];
            int k = 3;
            int exp = 2;
            int res = alg.NumberOfPairs(nums1, nums2, k);
            Assert.AreEqual(exp, res);
        }
    }
}
