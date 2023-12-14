using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _55_JumpGameUnitTest
    {
        _55_JumpGameAlg alg;

        [TestInitialize]
        public void Init()
        {
            alg = new _55_JumpGameAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var nums = new int[] { 2, 3, 1, 1, 4 };
            var res = alg.CanJump(nums);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var nums = new int[] { 3, 2, 1, 0, 4 };
            var res = alg.CanJump(nums);
            Assert.AreEqual(false, res);
        }
    }
}
