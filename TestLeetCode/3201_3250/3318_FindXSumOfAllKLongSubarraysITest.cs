using leetCode._3301_3350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3318_FindXSumOfAllKLongSubarraysITest
    {
        _3318_FindXSumOfAllKLongSubarraysIAlg alg = new _3318_FindXSumOfAllKLongSubarraysIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 1, 2, 2, 3, 4, 2, 3];
            int k = 6, x = 2;
            long[] res = alg.FindXSum(nums, k, x);
            long[] exp = [6, 10, 12];
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [3, 8, 7, 8, 7, 5];
            int k = 2, x = 2;
            long[] res = alg.FindXSum(nums, k, x);
            long[] exp = [11, 15, 15, 15, 12];
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
