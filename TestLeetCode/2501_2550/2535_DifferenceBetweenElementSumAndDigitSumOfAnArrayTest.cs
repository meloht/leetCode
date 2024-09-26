using leetCode._2501_2550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2501_2550
{
    [TestClass]
    public class _2535_DifferenceBetweenElementSumAndDigitSumOfAnArrayTest
    {
        _2535_DifferenceBetweenElementSumAndDigitSumOfAnArrayAlg alg = new _2535_DifferenceBetweenElementSumAndDigitSumOfAnArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 15, 6, 3];
            int exp = 9;
            int res = alg.DifferenceOfSum(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4];
            int exp = 0;
            int res = alg.DifferenceOfSum(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
