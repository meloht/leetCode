using leetCode._1951_2000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1951_2000
{
    [TestClass]
    public class _1958_CheckIfMoveIsLegalTest
    {
        _1958_CheckIfMoveIsLegalAlg alg = new _1958_CheckIfMoveIsLegalAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[][] board = [['.', '.', '.', 'B', '.', '.', '.', '.'], ['.', '.', '.', 'W', '.', '.', '.', '.'], ['.', '.', '.', 'W', '.', '.', '.', '.'], ['.', '.', '.', 'W', '.', '.', '.', '.'], ['W', 'B', 'B', '.', 'W', 'W', 'W', 'B'], ['.', '.', '.', 'B', '.', '.', '.', '.'], ['.', '.', '.', 'B', '.', '.', '.', '.'], ['.', '.', '.', 'W', '.', '.', '.', '.']];
            int rMove = 4, cMove = 3;
            char color = 'B';
            bool exp = true;
            bool res = alg.CheckMove(board, rMove, cMove, color);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            char[][] board = [['.', '.', '.', '.', '.', '.', '.', '.'], ['.', 'B', '.', '.', 'W', '.', '.', '.'], ['.', '.', 'W', '.', '.', '.', '.', '.'], ['.', '.', '.', 'W', 'B', '.', '.', '.'], ['.', '.', '.', '.', '.', '.', '.', '.'], ['.', '.', '.', '.', 'B', 'W', '.', '.'], ['.', '.', '.', '.', '.', '.', 'W', '.'], ['.', '.', '.', '.', '.', '.', '.', 'B']];
            int rMove = 4, cMove = 4;
            char color = 'W';
            bool exp = false;
            bool res = alg.CheckMove(board, rMove, cMove, color);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            char[][] board = [['B', 'B', 'B', '.', 'W', 'W', 'B', 'W'], ['B', 'B', '.', 'B', '.', 'B', 'B', 'B'], ['.', 'W', '.', '.', 'B', '.', 'B', 'W'], ['B', 'W', '.', 'W', 'B', '.', 'B', '.'], ['B', 'W', 'W', 'B', 'W', '.', 'B', 'B'], ['.', '.', 'W', '.', '.', 'W', '.', '.'], ['W', '.', 'W', 'B', '.', 'W', 'W', 'B'], ['B', 'B', 'W', 'W', 'B', 'W', '.', '.']];
            int rMove = 5, cMove = 6;
            char color = 'B';
            bool exp = true;
            bool res = alg.CheckMove(board, rMove, cMove, color);
            Assert.AreEqual(exp, res);
        }
    }
}
