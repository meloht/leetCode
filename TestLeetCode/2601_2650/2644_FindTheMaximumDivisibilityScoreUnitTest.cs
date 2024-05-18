using leetCode._2601_2650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2601_2650
{
    [TestClass]
    public class _2644_FindTheMaximumDivisibilityScoreUnitTest
    {
        _2644_FindTheMaximumDivisibilityScoreAlg alg = new _2644_FindTheMaximumDivisibilityScoreAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 7, 9, 3, 9], divisors = [5, 2, 3];
            int exp = 3;
            int res = alg.MaxDivScore(nums, divisors);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [20, 14, 21, 10], divisors = [5, 7, 5];
            int exp = 5;
            int res = alg.MaxDivScore(nums, divisors);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [12], divisors = [10, 16];
            int exp = 10;
            int res = alg.MaxDivScore(nums, divisors);
            Assert.AreEqual(exp, res);
        }
    }
}
