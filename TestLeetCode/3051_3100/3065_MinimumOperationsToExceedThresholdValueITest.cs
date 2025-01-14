using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3051_3100
{
    [TestClass]
    public class _3065_MinimumOperationsToExceedThresholdValueITest
    {
        _3065_MinimumOperationsToExceedThresholdValueIAlg alg = new _3065_MinimumOperationsToExceedThresholdValueIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 11, 10, 1, 3];
            int k = 10;
            int exp = 3;
            int res = alg.MinOperations(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 1, 2, 4, 9];
            int k = 1;
            int exp = 0;
            int res = alg.MinOperations(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 1, 2, 4, 9];
            int k = 9;
            int exp = 4;
            int res = alg.MinOperations(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
