using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _327_CountOfRangeSumUnitTest
    {
        _327_CountOfRangeSumAlg alg = new _327_CountOfRangeSumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [-2, 5, -1];
            int lower = -2, upper = 2;
            int exp = 3;
            int res = alg.CountRangeSum(nums, lower, upper);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0];
            int lower = 0, upper = 0;
            int exp = 1;
            int res = alg.CountRangeSum(nums, lower, upper);
            Assert.AreEqual(exp, res);
        }
    }
}
