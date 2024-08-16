using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3117_MinimumSumOfValuesByDividingArrayTest
    {
        _3117_MinimumSumOfValuesByDividingArrayAlg alg = new _3117_MinimumSumOfValuesByDividingArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 4, 3, 3, 2], andValues = [0, 3, 3, 2];
            int exp = 12;
            int res=alg.MinimumValueSum(nums, andValues);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 3, 5, 7, 7, 7, 5], andValues = [0, 7, 5];
            int exp = 17;
            int res = alg.MinimumValueSum(nums, andValues);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 3, 4], andValues = [2];
            int exp = -1;
            int res = alg.MinimumValueSum(nums, andValues);
            Assert.AreEqual(exp, res);
        }
    }
}
