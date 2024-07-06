using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _454_4SumIITest
    {
        _454_4SumIIAlg alg = new _454_4SumIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = [1, 2], nums2 = [-2, -1], nums3 = [-1, 2], nums4 = [0, 2];
            int exp = 2;
            int res = alg.FourSumCount(nums1, nums2, nums3, nums4);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = [0], nums2 = [0], nums3 = [0], nums4 = [0];
            int exp = 1;
            int res = alg.FourSumCount(nums1, nums2, nums3, nums4);
            Assert.AreEqual(exp, res);
        }
    }
}
