using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _209_MinimumSizeSubarraySumUnitTest
    {
        _209_MinimumSizeSubarraySumAlg alg = new _209_MinimumSizeSubarraySumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int target = 7;
            int[] nums = [2, 3, 1, 2, 4, 3];

            int res = alg.MinSubArrayLen(target, nums);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int target = 4;
            int[] nums = [1, 4, 4];

            int res = alg.MinSubArrayLen(target, nums);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int target = 11;
            int[] nums = [1, 1, 1, 1, 1, 1, 1, 1];

            int res = alg.MinSubArrayLen(target, nums);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int target = 11;
            int[] nums = [1, 2, 3, 4, 5];

            int res = alg.MinSubArrayLen(target, nums);
            Assert.AreEqual(3, res);
        }
    }
}
