using leetCode._3151_4000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_4000
{
    [TestClass]
    public class _3164_FindTheNumberOfGoodPairsIITest
    {
        _3164_FindTheNumberOfGoodPairsIIAlg alg = new _3164_FindTheNumberOfGoodPairsIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = [1, 3, 4], nums2 = [1, 3, 4];
            int k = 1;
            long exp = 5;
            long res = alg.NumberOfPairs(nums1, nums2, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = [1, 2, 4, 12], nums2 = [2, 4];
            int k = 3;
            long exp = 2;
            long res = alg.NumberOfPairs(nums1, nums2, k);
            Assert.AreEqual(exp, res);
        }
    }
}
