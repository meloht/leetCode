using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._1_50
{
    [TestClass]
    public class _45_JumpGameIIUnitTest
    {
        _45_JumpGameIIAlg alg;

        [TestInitialize]
        public void Init()
        {
            alg = new _45_JumpGameIIAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var nums = new int[] { 2, 3, 1, 1, 4 };
            var res = alg.Jump(nums);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var nums = new int[] { 2, 3, 0, 1, 4 };
            var res = alg.Jump(nums);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            var nums = new int[] { 0 };
            var res = alg.Jump(nums);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            var nums = new int[] { 0,0 };
            var res = alg.Jump(nums);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            var nums = new int[] { 1 };
            var res = alg.Jump(nums);
            Assert.AreEqual(0, res);
        }
    }
}
