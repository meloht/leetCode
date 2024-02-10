using leetCode._1251_1300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1251_1300
{
    [TestClass]
    public class _1275_FindWinnerOnATicTacToeGameUnitTest
    {
        _1275_FindWinnerOnATicTacToeGameAlg alg = new _1275_FindWinnerOnATicTacToeGameAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] moves = [[0, 0], [2, 0], [1, 1], [2, 1], [2, 2]];
            string exp = "A";
            string res = alg.Tictactoe(moves);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] moves = [[0, 0], [1, 1], [0, 1], [0, 2], [1, 0], [2, 0]];
            string exp = "B";
            string res = alg.Tictactoe(moves);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] moves = [[0, 0], [1, 1], [2, 0], [1, 0], [1, 2], [2, 1], [0, 1], [0, 2], [2, 2]];
            string exp = "Draw";
            string res = alg.Tictactoe(moves);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[][] moves = [[0, 0], [1, 1]];
            string exp = "Pending";
            string res = alg.Tictactoe(moves);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[][] moves = [[2, 0], [1, 1], [0, 2], [2, 1], [1, 2], [1, 0], [0, 0], [0, 1]];
            string exp = "B";
            string res = alg.Tictactoe(moves);
            Assert.AreEqual(exp, res);
        }
    }
}
