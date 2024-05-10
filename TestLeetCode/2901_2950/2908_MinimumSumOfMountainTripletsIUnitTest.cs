using leetCode._2901_2950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2901_2950
{
    [TestClass]
    public class _2908_MinimumSumOfMountainTripletsIUnitTest
    {
        _2908_MinimumSumOfMountainTripletsIAlg alg = new _2908_MinimumSumOfMountainTripletsIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [8, 6, 1, 5, 3];
            int exp = 9;
            int res = alg.MinimumSum(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [5, 4, 8, 7, 10, 2];
            int exp = 13;
            int res = alg.MinimumSum(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [6, 5, 4, 3, 4, 5];
            int exp = -1;
            int res = alg.MinimumSum(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
