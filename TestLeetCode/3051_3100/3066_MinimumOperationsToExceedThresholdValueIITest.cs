using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3051_3100
{
    [TestClass]
    public class _3066_MinimumOperationsToExceedThresholdValueIITest
    {
        _3066_MinimumOperationsToExceedThresholdValueIIAlg alg = new _3066_MinimumOperationsToExceedThresholdValueIIAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 11, 10, 1, 3];
            int k = 10;
            int exp = 2;
            int res = alg.MinOperations(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 1, 2, 4, 9];
            int k = 20;
            int exp = 4;
            int res = alg.MinOperations(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
