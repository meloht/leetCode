using leetCode._2901_2950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2901_2950
{
    [TestClass]
    public class _2931_MaximumSpendingAfterBuyingItemsTest
    {
        _2931_MaximumSpendingAfterBuyingItemsAlg alg = new _2931_MaximumSpendingAfterBuyingItemsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] values = [[8, 5, 2], [6, 4, 1], [9, 7, 3]];
            long exp = 285;
            long res = alg.MaxSpending(values);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] values = [[10, 8, 6, 4, 2], [9, 7, 5, 3, 2]];
            long exp = 386;
            long res = alg.MaxSpending(values);
            Assert.AreEqual(exp, res);
        }

        
    }
}
