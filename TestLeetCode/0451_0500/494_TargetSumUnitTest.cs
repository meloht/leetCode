using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _494_TargetSumUnitTest
    {
        _494_TargetSumAlg alg = new _494_TargetSumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 1, 1, 1, 1];
            int target = 3;
            int res = alg.FindTargetSumWays(nums, target);
            int exp = 5;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1];
            int target = 1;
            int res = alg.FindTargetSumWays(nums, target);
            int exp = 1;
            Assert.AreEqual(exp, res);
        }
    }
}
