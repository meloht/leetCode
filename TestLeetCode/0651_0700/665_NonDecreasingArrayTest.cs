using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _665_NonDecreasingArrayTest
    {
        _665_NonDecreasingArrayAlg alg = new _665_NonDecreasingArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 2, 3];
            bool exp = true;
            bool res = alg.CheckPossibility(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [4, 2, 1];
            bool exp = false;
            bool res = alg.CheckPossibility(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [5, 7, 1, 8];
            bool exp = true;
            bool res = alg.CheckPossibility(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [3, 4, 2, 3];
            bool exp = false;
            bool res = alg.CheckPossibility(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums = [3, 7, 2, 4];
            bool exp = false;
            bool res = alg.CheckPossibility(nums);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            int[] nums = [-1, 4, 2, 3];
            bool exp = true;
            bool res = alg.CheckPossibility(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
