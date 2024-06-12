using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _410_SplitArrayLargestSumUnitTest
    {
        _410_SplitArrayLargestSumAlg alg = new _410_SplitArrayLargestSumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [7, 2, 5, 10, 8];
            int k = 2;
            int exp = 18;
            int res = alg.SplitArray(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4, 5];
            int k = 2;
            int exp = 9;
            int res = alg.SplitArray(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 4, 4];
            int k = 3;
            int exp = 4;
            int res = alg.SplitArray(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
