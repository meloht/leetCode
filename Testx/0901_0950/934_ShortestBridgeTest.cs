using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _934_ShortestBridgeTest
    {
        _934_ShortestBridgeAlg alg = new _934_ShortestBridgeAlg();

        [Fact]
        public void Test01()
        {
            int[][] grid = [
                [0, 1], 
                [1, 0]];
            int exp = 1;
            int res = alg.ShortestBridge(grid);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[][] grid = [
                [0, 1, 0], 
                [0, 0, 0], 
                [0, 0, 1]];
            int exp = 2;
            int res = alg.ShortestBridge(grid);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[][] grid = [
                [1, 1, 1, 1, 1], 
                [1, 0, 0, 0, 1], 
                [1, 0, 1, 0, 1], 
                [1, 0, 0, 0, 1], 
                [1, 1, 1, 1, 1]];
            int exp = 1;
            int res = alg.ShortestBridge(grid);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int[][] grid = [
                [0, 0, 0, 0, 0, 0, 0], 
                [1, 0, 0, 1, 0, 0, 0], 
                [1, 1, 1, 1, 0, 0, 0], 
                [0, 0, 0, 1, 0, 0, 0], 
                [1, 0, 0, 0, 0, 0, 0], 
                [1, 1, 0, 0, 0, 0, 0], 
                [1, 0, 0, 0, 0, 0, 0]];
            int exp = 1;
            int res = alg.ShortestBridge(grid);
            Assert.Equal(exp, res);
        }
    }
}
