using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3222_FindTheWinningPlayerInCoinGameTest
    {
        _3222_FindTheWinningPlayerInCoinGameAlg alg = new _3222_FindTheWinningPlayerInCoinGameAlg();

        [TestMethod]
        public void TestCase01()
        {
            int x = 2, y = 7;
            string exp = "Alice";
            string res = alg.LosingPlayer(x, y);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int x = 4, y = 11;
            string exp = "Bob";
            string res = alg.LosingPlayer(x, y);
            Assert.AreEqual(exp, res);
        }
    }
}
