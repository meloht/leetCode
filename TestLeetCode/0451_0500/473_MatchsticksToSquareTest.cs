using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _473_MatchsticksToSquareTest
    {
        _473_MatchsticksToSquareAlg alg = new _473_MatchsticksToSquareAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] matchsticks = [1, 1, 2, 2, 2];
            bool exp = true;
            bool res = alg.Makesquare(matchsticks);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] matchsticks = [3, 3, 3, 3, 4];
            bool exp = false;
            bool res = alg.Makesquare(matchsticks);
            Assert.AreEqual(exp, res);
        }
    }
}
