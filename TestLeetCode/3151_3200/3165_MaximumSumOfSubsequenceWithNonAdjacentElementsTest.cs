using leetCode._3151_3200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_3200
{
    [TestClass]
    public class _3165_MaximumSumOfSubsequenceWithNonAdjacentElementsTest
    {
        _3165_MaximumSumOfSubsequenceWithNonAdjacentElementsAlg alg = new _3165_MaximumSumOfSubsequenceWithNonAdjacentElementsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 5, 9];
            int[][] queries = [[1, -2], [0, -3]];
            int exp = 21;
            int res=alg.MaximumSumSubsequence(nums, queries);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0, -1];
            int[][] queries = [[0, -5]];
            int exp = 0;
            int res = alg.MaximumSumSubsequence(nums, queries);
            Assert.AreEqual(exp, res);
        }
    }
}
