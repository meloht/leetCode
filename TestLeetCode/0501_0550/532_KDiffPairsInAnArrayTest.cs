using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _532_KDiffPairsInAnArrayTest
    {
        _532_KDiffPairsInAnArrayAlg alg = new _532_KDiffPairsInAnArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 1, 4, 1, 5];
            int k = 2;
            int exp = 2;
            int res = alg.FindPairs(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4, 5];
            int k = 1;
            int exp = 4;
            int res = alg.FindPairs(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 3, 1, 5, 4];
            int k = 0;
            int exp = 1;
            int res = alg.FindPairs(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [1, 2, 4, 4, 3, 3, 0, 9, 2, 3];
            int k = 3;
            int exp = 2;
            int res = alg.FindPairs(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
