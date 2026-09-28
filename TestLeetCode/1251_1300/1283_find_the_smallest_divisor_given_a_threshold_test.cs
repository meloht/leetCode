using leetCode._1251_1300;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1251_1300
{
    [TestClass]
    public class _1283_find_the_smallest_divisor_given_a_threshold_test
    {
        _1283_find_the_smallest_divisor_given_a_threshold alg = new _1283_find_the_smallest_divisor_given_a_threshold();

        [TestMethod]
        public void Test01()
        {
            int[] nums = [1, 2, 5, 9];
            int threshold = 6;
            int exp = 5;
            int res = alg.SmallestDivisor(nums, threshold);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[] nums = [2, 3, 5, 7, 11];
            int threshold = 11;
            int exp = 3;
            int res = alg.SmallestDivisor(nums, threshold);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            int[] nums = [19];
            int threshold = 5;
            int exp = 4;
            int res = alg.SmallestDivisor(nums, threshold);
            Assert.AreEqual(exp, res);
        }
    }
}
