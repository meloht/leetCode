using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _518_CoinChangeIIUnitTest
    {
        _518_CoinChangeIIAlg alg = new _518_CoinChangeIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int amount = 5;
            int[] coins = [1, 2, 5];
            int exp = 4;
            int res = alg.Change(amount, coins);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int amount = 3;
            int[] coins = [2];
            int exp = 0;
            int res = alg.Change(amount, coins);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int amount = 10;
            int[] coins = [10];
            int exp = 1;
            int res = alg.Change(amount, coins);
            Assert.AreEqual(exp, res);
        }
    }
}
