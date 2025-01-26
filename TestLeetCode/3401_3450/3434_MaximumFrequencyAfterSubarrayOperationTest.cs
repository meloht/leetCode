using leetCode._3401_3450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3401_3450
{
    [TestClass]
    public class _3434_MaximumFrequencyAfterSubarrayOperationTest
    {
        _3434_MaximumFrequencyAfterSubarrayOperationAlg alg = new _3434_MaximumFrequencyAfterSubarrayOperationAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4, 5, 6];
            int k = 1;
            int exp = 2;
            int res = alg.MaxFrequency(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [10, 2, 3, 4, 5, 5, 4, 3, 2, 2];
            int k = 10;
            int exp = 4;
            int res = alg.MaxFrequency(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
