using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _689_MaximumSumOf3NonOverlappingSubarraysTest
    {
        _689_MaximumSumOf3NonOverlappingSubarraysAlg alg = new _689_MaximumSumOf3NonOverlappingSubarraysAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 1, 2, 6, 7, 5, 1];
            int k = 2;
            int[] exp = [0, 3, 5];
            int[] res = alg.MaxSumOfThreeSubarrays(nums, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 1, 2, 1, 2, 1, 2, 1];
            int k = 2;
            int[] exp = [0, 2, 4];
            int[] res = alg.MaxSumOfThreeSubarrays(nums, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
