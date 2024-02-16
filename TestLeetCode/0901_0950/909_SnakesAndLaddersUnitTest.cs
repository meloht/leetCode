using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _909_SnakesAndLaddersUnitTest
    {
        _909_SnakesAndLaddersAlg alg = new _909_SnakesAndLaddersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] board = [
                [-1, -1, -1, -1, -1, -1],
                [-1, -1, -1, -1, -1, -1],
                [-1, -1, -1, -1, -1, -1],
                [-1, 35, -1, -1, 13, -1],
                [-1, -1, -1, -1, -1, -1],
                [-1, 15, -1, -1, -1, -1]];
            int exp = 4;
            int res = alg.SnakesAndLadders(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] board = [
                [-1, -1], 
                [-1, 3]];
            int exp = 1;
            int res = alg.SnakesAndLadders(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] board = [
                [-1, 7, -1], 
                [-1, 6, 9], 
                [-1, -1, 2]];
            int exp = 1;
            int res = alg.SnakesAndLadders(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] board = [
                [-1, 4, -1], 
                [6, 2, 6], 
                [-1, 3, -1]];
            int exp = 2;
            int res = alg.SnakesAndLadders(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[][] board = [
                [1, 1, -1],
                [1, 1, 1], 
                [-1, 1, 1]];
            int exp = -1;
            int res = alg.SnakesAndLadders(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            int[][] board = [
                [-1, 1, 2, -1],
                [2, 13, 15, -1],
                [-1, 10, -1, -1], 
                [-1, 6, 2, 8]];
            int exp = 2;
            int res = alg.SnakesAndLadders(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase07()
        {
            int[][] board = [
                [-1, -1, 16, 31, 29, -1], 
                [10, 20, -1, -1, 9, -1],
                [7, -1, -1, -1, 10, 28],
                [-1, 16, -1, 16, -1, -1],
                [28, -1, 5, 25, -1, -1], 
                [-1, 32, 30, -1, -1, -1]];
            int exp = 2;
            int res = alg.SnakesAndLadders(board);
            Assert.AreEqual(exp, res);
        }
    }
}
