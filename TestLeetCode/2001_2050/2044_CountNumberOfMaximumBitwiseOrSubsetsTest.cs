using leetCode._2001_2050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2001_2050
{
    [TestClass]
    public class _2044_CountNumberOfMaximumBitwiseOrSubsetsTest
    {
        _2044_CountNumberOfMaximumBitwiseOrSubsetsAlg alg = new _2044_CountNumberOfMaximumBitwiseOrSubsetsAlg();

        [TestMethod]
        public void Test01()
        {
            int[] nums = [3, 1];
            int exp = 2;
            int res = alg.CountMaxOrSubsets(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[] nums = [2, 2, 2];
            int exp = 7;
            int res = alg.CountMaxOrSubsets(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            int[] nums = [3, 2, 1, 5];
            int exp = 6;
            int res = alg.CountMaxOrSubsets(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
