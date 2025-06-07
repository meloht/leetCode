using leetCode._3151_3200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_3200
{
    [TestClass]
    public class _3194_MinimumAverageOfSmallestAndLargestElementsTest
    {
        _3194_MinimumAverageOfSmallestAndLargestElementsAlg alg = new _3194_MinimumAverageOfSmallestAndLargestElementsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [7, 8, 3, 4, 15, 13, 4, 1];
            double exp = 5.5;
            double res = alg.MinimumAverage(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 9, 8, 3, 10, 5];
            double exp = 5.5;
            double res = alg.MinimumAverage(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 3, 7, 8, 9];
            double exp = 5.0;
            double res = alg.MinimumAverage(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
