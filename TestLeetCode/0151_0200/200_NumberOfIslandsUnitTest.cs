using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0151_0200
{
    [TestClass]
    public class _200_NumberOfIslandsUnitTest
    {
        _200_NumberOfIslandsAlg alg = new _200_NumberOfIslandsAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[][] grid = [
                ['1', '1', '1', '1', '0'],
                ['1', '1', '0', '1', '0'],
                ['1', '1', '0', '0', '0'],
                ['0', '0', '0', '0', '0']
];
            int res = alg.NumIslands(grid);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            char[][] grid = [
                ['1', '1', '0', '0', '0'],
                ['1', '1', '0', '0', '0'],
                ['0', '0', '1', '0', '0'],
                ['0', '0', '0', '1', '1']
];
            int res = alg.NumIslands(grid);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            char[][] grid = [['1', '1']];
            int res = alg.NumIslands(grid);
            Assert.AreEqual(1, res);
        }
    }
}
