using leetCode._2801_2850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2801_2850
{
    [TestClass]
    public class _2806_AccountBalanceAfterRoundedPurchaseUnitTest
    {
        _2806_AccountBalanceAfterRoundedPurchaseAlg alg = new _2806_AccountBalanceAfterRoundedPurchaseAlg();

        [TestMethod]
        public void TestCase01()
        {
            int purchaseAmount = 9;
            int exp = 90;
            int res = alg.AccountBalanceAfterPurchase(purchaseAmount);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int purchaseAmount = 15;
            int exp = 80;
            int res = alg.AccountBalanceAfterPurchase(purchaseAmount);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int purchaseAmount = 11;
            int exp = 90;
            int res = alg.AccountBalanceAfterPurchase(purchaseAmount);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int purchaseAmount = 20;
            int exp = 80;
            int res = alg.AccountBalanceAfterPurchase(purchaseAmount);
            Assert.AreEqual(exp, res);
        }
    }
}
