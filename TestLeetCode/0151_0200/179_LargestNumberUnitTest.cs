using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0151_0200
{
    [TestClass]
    public class _179_LargestNumberUnitTest
    {
        _179_LargestNumberAlg alg = new _179_LargestNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [10, 2];
            string exp = "210";
            var res = alg.LargestNumber(nums);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [3, 30, 34, 5, 9];
            string exp = "9534330";
            var res = alg.LargestNumber(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [432, 43243];
            string exp = "43243432";
            var res = alg.LargestNumber(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [34323, 3432];
            string exp = "343234323";
            var res = alg.LargestNumber(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums = [0, 0];
            string exp = "0";
            var res = alg.LargestNumber(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
