using leetCode._2401_2450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2401_2450
{
    [TestClass]
    public class _2419_LongestSubarrayWithMaximumBitwiseAndTest
    {
        _2419_LongestSubarrayWithMaximumBitwiseAndAlg alg = new _2419_LongestSubarrayWithMaximumBitwiseAndAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 3, 2, 2];
            int exp = 2;
            int res = alg.LongestSubarray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4];
            int exp = 1;
            int res = alg.LongestSubarray(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
