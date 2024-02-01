using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _239_SlidingWindowMaximumUnitTest
    {
        _239_SlidingWindowMaximumAlg alg = new _239_SlidingWindowMaximumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, -1, -3, 5, 3, 6, 7];
            int k = 3;
            int[] exp = [3, 3, 5, 5, 6, 7];
            int[] res = alg.MaxSlidingWindow(nums, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1];
            int k = 1;
            int[] exp = [1];
            int[] res = alg.MaxSlidingWindow(nums, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [-7, -8, 7, 5, 7, 1, 6, 0];
            int k = 4;
            int[] exp = [7, 7, 7, 7, 7];
            int[] res = alg.MaxSlidingWindow(nums, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
