using leetCode._1651_1700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1651_1700
{
    [TestClass]
    public class _1690_StoneGameVIIUnitTest
    {
        _1690_StoneGameVIIAlg alg = new _1690_StoneGameVIIAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[] stones = [5, 3, 1, 4, 2];
            int exp = 6;
            int res = alg.StoneGameVII(stones);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] stones = [7, 90, 5, 1, 100, 10, 10, 2];
            int exp = 122;
            int res = alg.StoneGameVII(stones);
            Assert.AreEqual(exp, res);
        }
    }
}
