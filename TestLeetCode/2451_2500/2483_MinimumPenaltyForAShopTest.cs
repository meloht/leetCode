using leetCode._2451_2500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2451_2500
{
    [TestClass]
    public class _2483_MinimumPenaltyForAShopTest
    {
        _2483_MinimumPenaltyForAShopAlg alg = new _2483_MinimumPenaltyForAShopAlg();

        [TestMethod]
        public void Test01()
        {
            string customers = "YYNY";
            int exp = 2;
            int res = alg.BestClosingTime(customers);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            string customers = "NNNNN";
            int exp = 0;
            int res = alg.BestClosingTime(customers);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            string customers = "YYYY";
            int exp = 4;
            int res = alg.BestClosingTime(customers);
            Assert.AreEqual(exp, res);
        }
    }
}
