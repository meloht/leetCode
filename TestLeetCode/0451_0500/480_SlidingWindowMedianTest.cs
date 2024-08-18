using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _480_SlidingWindowMedianTest
    {
        _480_SlidingWindowMedianAlg alg = new _480_SlidingWindowMedianAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, -1, -3, 5, 3, 6, 7];
            int k = 3;
            double[] exp = [1, -1, -1, 3, 5, 6];
            var res = alg.MedianSlidingWindow(nums, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4, 2, 3, 1, 4, 2];
            int k = 3;
            double[] exp = [2, 3, 3, 3, 2, 3, 2];
            var res = alg.MedianSlidingWindow(nums, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [2147483647, 2147483647];
            int k = 2;
            double[] exp = [2147483647.0];
            var res = alg.MedianSlidingWindow(nums, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
