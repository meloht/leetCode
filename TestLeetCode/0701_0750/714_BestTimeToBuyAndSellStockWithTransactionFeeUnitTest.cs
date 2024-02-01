using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _714_BestTimeToBuyAndSellStockWithTransactionFeeUnitTest
    {
        _714_BestTimeToBuyAndSellStockWithTransactionFeeAlg alg = new _714_BestTimeToBuyAndSellStockWithTransactionFeeAlg();
       
        [TestMethod]
        public void TestCase01()
        {
            int[] prices = [1, 3, 2, 8, 4, 9];
            int fee = 2;
            int exp = 8;
          
            int res = alg.MaxProfit(prices, fee);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] prices = [1, 3, 7, 5, 10, 3];
            int fee = 3;
            int exp = 6;

            int res = alg.MaxProfit(prices, fee);
            Assert.AreEqual(exp, res);
        }
    }
}
