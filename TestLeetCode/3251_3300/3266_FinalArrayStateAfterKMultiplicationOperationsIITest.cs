using leetCode._3251_3300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3251_3300
{
    [TestClass]
    public class _3266_FinalArrayStateAfterKMultiplicationOperationsIITest
    {
        _3266_FinalArrayStateAfterKMultiplicationOperationsIIAlg alg = new _3266_FinalArrayStateAfterKMultiplicationOperationsIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 1, 3, 5, 6];
            int k = 5, multiplier = 2;
            int[] exp = [8, 4, 6, 5, 6];
            int[] res = alg.GetFinalState(nums, k, multiplier);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [100000, 2000];
            int k = 2, multiplier = 1000000;
            int[] exp = [999999307, 999999993];
            int[] res = alg.GetFinalState(nums, k, multiplier);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [66307295, 441787703, 589039035, 322281864];
            int k = 900900704, multiplier = 641725;
            int[] exp = [664480092, 763599523, 886046925, 47878852];
            int[] res = alg.GetFinalState(nums, k, multiplier);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
