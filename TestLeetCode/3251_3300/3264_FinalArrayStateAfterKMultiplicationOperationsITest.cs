using leetCode._3251_3300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3251_3300
{
    [TestClass]
    public class _3264_FinalArrayStateAfterKMultiplicationOperationsITest
    {
        _3264_FinalArrayStateAfterKMultiplicationOperationsIAlg alg = new _3264_FinalArrayStateAfterKMultiplicationOperationsIAlg();

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
            int[] nums = [1, 2];
            int k = 3, multiplier = 4;
            int[] exp = [16, 8];
            int[] res = alg.GetFinalState(nums, k, multiplier);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
