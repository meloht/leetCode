using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _673_NumberOfLongestIncreasingSubsequenceTest
    {
        _673_NumberOfLongestIncreasingSubsequenceAlg alg = new _673_NumberOfLongestIncreasingSubsequenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, 5, 4, 7];
            int exp = 2;
            int res = alg.FindNumberOfLIS(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 2, 2, 2, 2];
            int exp = 5;
            int res = alg.FindNumberOfLIS(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
