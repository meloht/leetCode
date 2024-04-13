using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _643_MaximumAverageSubarrayIUnitTest
    {
        _643_MaximumAverageSubarrayIAlg alg = new _643_MaximumAverageSubarrayIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 12, -5, -6, 50, 3];
            int k = 4;
            double exp = 12.75;
            var res = alg.FindMaxAverage(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [5];
            int k = 1;
            double exp = 5.00000;
            var res = alg.FindMaxAverage(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
