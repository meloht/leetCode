using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._1_50
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
    }
}
