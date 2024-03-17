using leetCode._1451_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1451_1500
{
    [TestClass]
    public class _1498_NumberOfSubsequencesThatSatisfyTheGivenSumConditionUnitTest
    {
        _1498_NumberOfSubsequencesThatSatisfyTheGivenSumConditionAlg alg = new _1498_NumberOfSubsequencesThatSatisfyTheGivenSumConditionAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 5, 6, 7];
            int target = 9;
            int exp = 4;
            int res=alg.NumSubseq(nums, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [3, 3, 6, 8];
            int target = 10;
            int exp = 6;
            int res = alg.NumSubseq(nums, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [2, 3, 3, 4, 6, 7];
            int target = 12;
            int exp = 61;
            int res = alg.NumSubseq(nums, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [14, 4, 6, 6, 20, 8, 5, 6, 8, 12, 6, 10, 14, 9, 17, 16, 9, 7, 14, 11, 14, 15, 13, 11, 10, 18, 13, 17, 17, 14, 17, 7, 9, 5, 10, 13, 8, 5, 18, 20, 7, 5, 5, 15, 19, 14];
            int target = 22;
            int exp = 272187084;
            int res = alg.NumSubseq(nums, target);
            Assert.AreEqual(exp, res);
        }
    }
}
