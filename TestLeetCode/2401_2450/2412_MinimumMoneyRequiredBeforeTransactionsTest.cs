using leetCode._2401_2450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Test._2401_2450
{
    [TestClass]
    public class _2412_MinimumMoneyRequiredBeforeTransactionsTest
    {
        _2412_MinimumMoneyRequiredBeforeTransactionsAlg alg = new _2412_MinimumMoneyRequiredBeforeTransactionsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] transactions = [[2, 1], [5, 0], [4, 2]];
            long exp = 10;
            long res = alg.MinimumMoney(transactions);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] transactions = [[3, 0], [0, 3]];
            long exp = 3;
            long res = alg.MinimumMoney(transactions);
            Assert.AreEqual(exp, res);
        }
    }
}
