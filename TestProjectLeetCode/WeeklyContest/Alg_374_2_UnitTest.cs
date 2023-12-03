using leetCode.WeeklyContest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode.WeeklyContest
{
    [TestClass]
    public class Alg_374_2_UnitTest
    {
        Alg_374 alg;
        [TestInitialize]
        public void Init()
        {
            alg = new Alg_374();
        }

        [TestMethod]
        public void TestCase01()
        {
            int[] coins = { 1, 4, 10 };
            int res = alg.MinimumAddedCoins(coins,19);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] coins = { 1, 4, 10, 5, 7, 19 };
            int res = alg.MinimumAddedCoins(coins, 19);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] coins = { 1, 1, 1 };
            int res = alg.MinimumAddedCoins(coins, 20);
            Assert.AreEqual(3, res);
        }
    }
}
