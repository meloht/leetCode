using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _918_MaximumSumCircularSubarrayUnitTest
    {
        _918_MaximumSumCircularSubarrayAlg alg = new _918_MaximumSumCircularSubarrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, -2, 3, -2];
            int exp = 3;
            int res = alg.MaxSubarraySumCircular(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [5, -3, 5];
            int exp = 10;
            int res = alg.MaxSubarraySumCircular(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [3, -2, 2, -3];
            int exp = 3;
            int res = alg.MaxSubarraySumCircular(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [6, 9, -3];
            int exp = 15;
            int res = alg.MaxSubarraySumCircular(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums = [-2, 4, -5, 4, -5, 9, 4];
            int exp = 15;
            int res = alg.MaxSubarraySumCircular(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
