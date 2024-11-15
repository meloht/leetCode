using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3239_MinimumNumberOfFlipsToMakeBinaryGridPalindromicITest
    {
        _3239_MinimumNumberOfFlipsToMakeBinaryGridPalindromicIAlg alg = new _3239_MinimumNumberOfFlipsToMakeBinaryGridPalindromicIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[1, 0, 0], [0, 0, 0], [0, 0, 1]];
            int exp = 2;
            int res = alg.MinFlips(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[0, 1], [0, 1], [0, 0]];
            int exp = 1;
            int res = alg.MinFlips(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[1], [0]];
            int exp = 0;
            int res = alg.MinFlips(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
