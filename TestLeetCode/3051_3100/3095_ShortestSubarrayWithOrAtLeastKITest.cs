using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3051_3100
{
    [TestClass]
    public class _3095_ShortestSubarrayWithOrAtLeastKITest
    {
        _3095_ShortestSubarrayWithOrAtLeastKIAlg alg = new _3095_ShortestSubarrayWithOrAtLeastKIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3];
            int k = 2;
            int exp = 1;
            int res = alg.MinimumSubarrayLength(nums, k);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 1, 8];
            int k = 10;
            int exp = 3;
            int res = alg.MinimumSubarrayLength(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2];
            int k = 0;
            int exp = 1;
            int res = alg.MinimumSubarrayLength(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [1, 2, 32, 21];
            int k = 55;
            int exp = 3;
            int res = alg.MinimumSubarrayLength(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
