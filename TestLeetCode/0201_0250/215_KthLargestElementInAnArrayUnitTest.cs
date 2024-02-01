using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _215_KthLargestElementInAnArrayUnitTest
    {
        _215_KthLargestElementInAnArrayAlg alg = new _215_KthLargestElementInAnArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 2, 1, 5, 6, 4];
            int k = 2;
            int res = alg.FindKthLargest(nums, k);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [3, 2, 3, 1, 2, 4, 5, 5, 6];
            int k = 4;
            int res = alg.FindKthLargest(nums, k);
            Assert.AreEqual(4, res);
        }
    }
}
