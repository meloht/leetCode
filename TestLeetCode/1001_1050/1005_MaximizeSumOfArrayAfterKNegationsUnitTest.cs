using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1005_MaximizeSumOfArrayAfterKNegationsUnitTest
    {
        _1005_MaximizeSumOfArrayAfterKNegationsAlg alg = new _1005_MaximizeSumOfArrayAfterKNegationsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 2, 3];
            int k = 1;
            int exp = 5;
            int res = alg.LargestSumAfterKNegations(nums, k);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [3, -1, 0, 2];
            int k = 3;
            int exp = 6;
            int res = alg.LargestSumAfterKNegations(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [2, -3, -1, 5, -4];
            int k = 2;
            int exp = 13;
            int res = alg.LargestSumAfterKNegations(nums, k);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [-8, 3, -5, -3, -5, -2];
            int k = 6;
            int exp = 22;
            int res = alg.LargestSumAfterKNegations(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
