using leetCode._2801_2850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2801_2850
{
    [TestClass]
    public class _2831_FindTheLongestEqualSubarrayUnitTest
    {
        _2831_FindTheLongestEqualSubarrayAlg alg = new _2831_FindTheLongestEqualSubarrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, 2, 3, 1, 3]; int k = 3;
            int exp = 3;
            int res = alg.LongestEqualSubarray(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 1, 2, 2, 1, 1]; int k = 2;
            int exp = 4;
            int res = alg.LongestEqualSubarray(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
