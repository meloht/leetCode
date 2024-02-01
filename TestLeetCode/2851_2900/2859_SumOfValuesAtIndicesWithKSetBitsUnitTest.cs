using leetCode._2851_2900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2851_2900
{
    [TestClass]
    public class _2859_SumOfValuesAtIndicesWithKSetBitsUnitTest
    {
        _2859_SumOfValuesAtIndicesWithKSetBitsAlg alg = new _2859_SumOfValuesAtIndicesWithKSetBitsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [5, 10, 1, 5, 2];
            int k = 1;
            int exp = 13;
            int res = alg.SumIndicesWithKSetBits(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [4, 3, 2, 1];
            int k = 2;
            int exp = 1;
            int res = alg.SumIndicesWithKSetBits(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
