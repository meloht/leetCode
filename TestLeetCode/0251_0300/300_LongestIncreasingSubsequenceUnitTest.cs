using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _300_LongestIncreasingSubsequenceUnitTest
    {
        _300_LongestIncreasingSubsequenceAlg alg = new _300_LongestIncreasingSubsequenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [10, 9, 2, 5, 3, 7, 101, 18];
            int exp = 4;
            int res = alg.LengthOfLIS(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0, 1, 0, 3, 2, 3];
            int exp = 4;
            int res = alg.LengthOfLIS(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [7, 7, 7, 7, 7, 7, 7];
            int exp = 1;
            int res = alg.LengthOfLIS(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
