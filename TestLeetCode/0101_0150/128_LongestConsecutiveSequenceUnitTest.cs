using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _128_LongestConsecutiveSequenceUnitTest
    {
        _128_LongestConsecutiveSequenceAlg alg = new _128_LongestConsecutiveSequenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [100, 4, 200, 1, 3, 2];
            var res = alg.LongestConsecutive(nums);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];
            var res = alg.LongestConsecutive(nums);
            Assert.AreEqual(9, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 0, 1];
            var res = alg.LongestConsecutive(nums);
            Assert.AreEqual(3, res);
        }
    }
}
