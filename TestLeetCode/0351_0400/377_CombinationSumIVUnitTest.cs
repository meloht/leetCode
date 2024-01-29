using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0351_0400
{
    [TestClass]
    public class _377_CombinationSumIVUnitTest
    {
        _377_CombinationSumIVAlg alg = new _377_CombinationSumIVAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3];
            int target = 4;
            int exp = 7;
            int res = alg.CombinationSum4(nums, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [9];
            int target = 3;
            int exp = 0;
            int res = alg.CombinationSum4(nums, target);
            Assert.AreEqual(exp, res);
        }
    }
}
