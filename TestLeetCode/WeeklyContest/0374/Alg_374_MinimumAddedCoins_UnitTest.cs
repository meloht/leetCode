using leetCode.WeeklyContest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WeeklyContest
{
    [TestClass]
    public class Alg_374_MinimumAddedCoins_UnitTest
    {
        Alg_374_MinimumAddedCoins alg;
        [TestInitialize]
        public void Init()
        {
            alg = new Alg_374_MinimumAddedCoins();
        }

        [TestMethod]
        public void TestCase01()
        {
            int[] coins = { 1, 4, 10 };
            int res = alg.MinimumAddedCoins(coins,19);//1,2,4,8,10
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] coins = { 1, 4, 10, 5, 7, 19 };
            int res = alg.MinimumAddedCoins(coins, 19);//1,2,4,5,7,10,19
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] coins = { 1, 1, 1 };
            int res = alg.MinimumAddedCoins(coins, 20);//1,1,1,4,8,16
            Assert.AreEqual(3, res);
        }
    }
}
