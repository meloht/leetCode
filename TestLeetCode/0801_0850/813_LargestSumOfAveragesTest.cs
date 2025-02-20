using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _813_LargestSumOfAveragesTest
    {
        _813_LargestSumOfAveragesAlg alg = new _813_LargestSumOfAveragesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [9, 1, 2, 3, 9];
            int k = 3;
            double exp = 20.00000;
            double res = alg.LargestSumOfAverages(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7];
            int k = 4;
            double exp = 20.50000;
            double res = alg.LargestSumOfAverages(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
