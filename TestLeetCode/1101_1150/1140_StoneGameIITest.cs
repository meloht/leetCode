using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1140_StoneGameIITest
    {
        _1140_StoneGameIIAlg alg = new _1140_StoneGameIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] piles = [2, 7, 9, 4, 4];
            int exp = 10;
            int res = alg.StoneGameII(piles);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] piles = [1, 2, 3, 4, 5, 100];
            int exp = 104;
            int res = alg.StoneGameII(piles);
            Assert.AreEqual(exp, res);
        }
    }
}
