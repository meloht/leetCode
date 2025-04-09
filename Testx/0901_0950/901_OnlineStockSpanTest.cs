using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0901_0950._901_OnlineStockSpanAlg;

namespace Testx._0901_0950
{
    public class _901_OnlineStockSpanTest
    {
        [Fact]
        public void Test01()
        {
            StockSpanner stockSpanner = new StockSpanner();
            Assert.Equal(1, stockSpanner.Next(100)); // 返回 1
            Assert.Equal(1, stockSpanner.Next(80));  // 返回 1
            Assert.Equal(1, stockSpanner.Next(60));  // 返回 1
            Assert.Equal(2, stockSpanner.Next(70));  // 返回 2
            Assert.Equal(1, stockSpanner.Next(60));  // 返回 1
            Assert.Equal(4, stockSpanner.Next(75));  // 返回 4 ，因为截至今天的最后 4 个股价 (包括今天的股价 75) 都小于或等于今天的股价。
            Assert.Equal(6, stockSpanner.Next(85));  // 返回 6
        }
    }
}
