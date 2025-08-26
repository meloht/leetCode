using leetCode._3001_3050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3001_3050
{
    [TestClass]
    public class _3000_MaximumAreaOfLongestDiagonalRectangleTest
    {
        _3000_MaximumAreaOfLongestDiagonalRectangleAlg alg = new _3000_MaximumAreaOfLongestDiagonalRectangleAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] dimensions = [[9, 3], [8, 6]];
            int exp = 48;
            int res = alg.AreaOfMaxDiagonal(dimensions);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] dimensions = [[3, 4], [4, 3]];
            int exp = 12;
            int res = alg.AreaOfMaxDiagonal(dimensions);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] dimensions = [[6, 5], [8, 6], [2, 10], [8, 1], [9, 2], [3, 5], [3, 5]];
            int exp = 20;
            int res = alg.AreaOfMaxDiagonal(dimensions);
            Assert.AreEqual(exp, res);
        }
    }
}
