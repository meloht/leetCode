using leetCode._3001_3050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3001_3050
{
    [TestClass]
    public class _3021_AliceAndBobPlayingFlowerGameTest
    {
        _3021_AliceAndBobPlayingFlowerGameAlg alg = new _3021_AliceAndBobPlayingFlowerGameAlg();

        [TestMethod]
        public void Test01()
        {
            int n = 3, m = 2;
            long exp = 3;
            long res = alg.FlowerGame(n, m);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int n = 1, m = 1;
            long exp = 0;
            long res = alg.FlowerGame(n, m);
            Assert.AreEqual(exp, res);
        }
    }
}
