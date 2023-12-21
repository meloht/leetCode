using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _130_SurroundedRegionsUnitTest
    {
        _130_SurroundedRegionsAlg alg = new _130_SurroundedRegionsAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[][] board = [['X', 'X', 'X', 'X'], ['X', 'O', 'O', 'X'], ['X', 'X', 'O', 'X'], ['X', 'O', 'X', 'X']];
            char[][] exp = [['X', 'X', 'X', 'X'], ['X', 'X', 'X', 'X'], ['X', 'X', 'X', 'X'], ['X', 'O', 'X', 'X']];

            alg.Solve(board);
            bool bl = Utils.IsSameArr(exp, board);
            Assert.IsTrue(bl);
        }


        [TestMethod]
        public void TestCase02()
        {
            char[][] board = [['X']];
            char[][] exp = [['X']];

            alg.Solve(board);
            bool bl = Utils.IsSameArr(exp, board);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            char[][] board = [['X', 'O'], ['O', 'X']];
            char[][] exp = [['X', 'O'], ['O', 'X']];

            alg.Solve(board);
            bool bl = Utils.IsSameArr(exp, board);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase04()
        {
            char[][] board = [['X', 'O', 'X'], ['O', 'X', 'O'], ['X', 'O', 'X']];
            char[][] exp = [['X', 'O', 'X'], ['O', 'X', 'O'], ['X', 'O', 'X']];

            alg.Solve(board);
            bool bl = Utils.IsSameArr(exp, board);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase05()
        {
            char[][] board = [['X', 'O', 'X', 'X'], ['O', 'X', 'O', 'X'], ['X', 'O', 'X', 'O'], ['O', 'X', 'O', 'X']];
            char[][] exp = [['X', 'O', 'X', 'X'], ['O', 'X', 'X', 'X'], ['X', 'X', 'X', 'O'], ['O', 'X', 'O', 'X']];

            alg.Solve(board);
            bool bl = Utils.IsSameArr(exp, board);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase06()
        {
            char[][] board = [['O', 'X', 'X', 'O', 'X'], ['X', 'O', 'O', 'X', 'O'], ['X', 'O', 'X', 'O', 'X'], ['O', 'X', 'O', 'O', 'O'], ['X', 'X', 'O', 'X', 'O']];
            char[][] exp = [['O', 'X', 'X', 'O', 'X'], ['X', 'X', 'X', 'X', 'O'], ['X', 'X', 'X', 'O', 'X'], ['O', 'X', 'O', 'O', 'O'], ['X', 'X', 'O', 'X', 'O']];

            alg.Solve(board);
            bool bl = Utils.IsSameArr(exp, board);
            Assert.IsTrue(bl);
        }
    }
}
