using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0001_0050
{

    [TestClass]
    public class _42_TrappingRainWaterUnitTest
    {
        _42_TrappingRainWaterAlg alg;

        [TestInitialize]
        public void Init()
        {
            alg = new _42_TrappingRainWaterAlg();

        }
        [TestMethod]
        public void TestCase01()
        {
            var candidates = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            var res = alg.Trap(candidates);
            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var candidates = new int[] { 4, 2, 0, 3, 2, 5 };
            var res = alg.Trap(candidates);
            Assert.AreEqual(9, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            var candidates = new int[] { 4, 2, 3 };
            var res = alg.Trap(candidates);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            var candidates = new int[] { 5, 4, 1, 2 };
            var res = alg.Trap(candidates);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            var candidates = new int[] { 0, 1, 2, 0, 3, 0, 1, 2, 0, 0, 4, 2, 1, 2, 5, 0, 1, 2, 0, 2 };
            var res = alg.Trap(candidates);
            Assert.AreEqual(26, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            var candidates = new int[] { 4, 3, 3, 9, 3, 0, 9, 2, 8, 3 };
            var res = alg.Trap(candidates);
            Assert.AreEqual(23, res);
        }

        [TestMethod]
        public void TestCase07()
        {
            var candidates = new int[] { 2, 4, 5, 6, 8, 5, 5, 0, 0, 0, 3, 3 };
            var res = alg.Trap(candidates);
            Assert.AreEqual(9, res);
        }

        [TestMethod]
        public void TestCase08()
        {
            var candidates = new int[] { 4, 9, 4, 5, 3, 2 };
            var res = alg.Trap(candidates);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void TestCase09()
        {
            var candidates = new int[] { 2, 8, 5, 5, 6, 1, 7, 4, 5 };
            var res = alg.Trap(candidates);
            Assert.AreEqual(12, res);
        }

        [TestMethod]
        public void TestCase10()
        {
            var candidates = new int[] { 8, 5, 4, 1, 8, 9, 3, 0, 0 };
            var res = alg.Trap(candidates);
            Assert.AreEqual(14, res);
        }
    }
}
