using leetCode._3301_3350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3301_3350
{
    [TestClass]
    public class _3349_AdjacentIncreasingSubarraysDetectionITest
    {
        _3349_AdjacentIncreasingSubarraysDetectionIAlg alg = new _3349_AdjacentIncreasingSubarraysDetectionIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 5, 7, 8, 9, 2, 3, 4, 3, 1];
            int k = 3;
            bool exp = true;
            bool res=alg.HasIncreasingSubarrays(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4, 4, 4, 4, 5, 6, 7];
            int k = 5;
            bool exp = false;
            bool res = alg.HasIncreasingSubarrays(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
