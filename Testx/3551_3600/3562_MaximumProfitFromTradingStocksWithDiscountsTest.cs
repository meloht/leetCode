using leetCode._3551_3600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3551_3600
{
    public class _3562_MaximumProfitFromTradingStocksWithDiscountsTest
    {
        _3562_MaximumProfitFromTradingStocksWithDiscountsAlg alg = new _3562_MaximumProfitFromTradingStocksWithDiscountsAlg();

        [Fact]
        public void Test1()
        {
            int n = 2;
            int[] present = [1, 2], future = [4, 3];
            int[][] hierarchy = [[1, 2]];
            int budget = 3;
            int exp = 5;
            int res = alg.MaxProfit(n, present, future, hierarchy, budget);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int n = 2;
            int[] present = [3, 4], future = [5, 8];
            int[][] hierarchy = [[1, 2]];
            int budget = 4;
            int exp = 4;
            int res = alg.MaxProfit(n, present, future, hierarchy, budget);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test3()
        {
            int n = 3;
            int[] present = [4, 6, 8], future = [7, 9, 11];
            int[][] hierarchy = [[1, 2], [1, 3]];
            int budget = 10;
            int exp = 10;
            int res = alg.MaxProfit(n, present, future, hierarchy, budget);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test4()
        {
            int n = 3;
            int[] present = [5, 2, 3], future = [8, 5, 6];
            int[][] hierarchy = [[1, 2], [2, 3]];
            int budget = 7;
            int exp = 12;
            int res = alg.MaxProfit(n, present, future, hierarchy, budget);
            Assert.Equal(exp, res);
        }
    }
}
