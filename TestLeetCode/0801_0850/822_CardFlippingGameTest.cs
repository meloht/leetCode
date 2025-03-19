using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _822_CardFlippingGameTest
    {
        _822_CardFlippingGameAlg alg = new _822_CardFlippingGameAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] fronts = [1, 2, 4, 4, 7], backs = [1, 3, 4, 1, 3];
            int exp = 2;
            int res = alg.Flipgame(fronts, backs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] fronts = [1], backs = [1];
            int exp = 0;
            int res = alg.Flipgame(fronts, backs);
            Assert.AreEqual(exp, res);
        }
    }
}
