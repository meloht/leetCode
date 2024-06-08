using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _403_FrogJumpUnitTest
    {
        _403_FrogJumpAlg alg = new _403_FrogJumpAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] stones = [0, 1, 3, 5, 6, 8, 12, 17];
            bool exp = true;
            bool res = alg.CanCross(stones);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] stones = [0, 1, 2, 3, 4, 8, 9, 11];
            bool exp = false;
            bool res = alg.CanCross(stones);
            Assert.AreEqual(exp, res);
        }
    }
}
