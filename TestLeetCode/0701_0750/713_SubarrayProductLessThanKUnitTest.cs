using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _713_SubarrayProductLessThanKUnitTest
    {
        _713_SubarrayProductLessThanKAlg alg = new _713_SubarrayProductLessThanKAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [10, 5, 2, 6];
            int k = 100;
            int exp = 8;
            int res = alg.NumSubarrayProductLessThanK(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3];
            int k = 0;
            int exp = 0;
            int res = alg.NumSubarrayProductLessThanK(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
