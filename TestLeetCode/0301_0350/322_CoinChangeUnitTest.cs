using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0301_0350
{
    [TestClass]
    public class _322_CoinChangeUnitTest
    {
        _322_CoinChangeAlg alg = new _322_CoinChangeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] coins = [1, 2, 5];
            int amount = 11;
            int exp = 3;
            int res = alg.CoinChange(coins, amount);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] coins = [2];
            int amount = 3;
            int exp = -1;
            int res = alg.CoinChange(coins, amount);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] coins = [1];
            int amount = 0;
            int exp = 0;
            int res = alg.CoinChange(coins, amount);
            Assert.AreEqual(exp, res);
        }
    }
}
