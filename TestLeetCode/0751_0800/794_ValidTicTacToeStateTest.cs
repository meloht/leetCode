using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _794_ValidTicTacToeStateTest
    {
        _794_ValidTicTacToeStateAlg alg = new _794_ValidTicTacToeStateAlg();


        [TestMethod]
        public void TestCase01()
        {
            string[] board = ["O  ", "   ", "   "];
            bool exp = false;
            bool res = alg.ValidTicTacToe(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] board = ["XOX", " X ", "   "];
            bool exp = false;
            bool res = alg.ValidTicTacToe(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] board = ["XOX", "O O", "XOX"];
            bool exp = true;
            bool res = alg.ValidTicTacToe(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string[] board = [
                "XXX", 
                "OOX", 
                "OOX"];
            bool exp = true;
            bool res = alg.ValidTicTacToe(board);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase05()
        {
            string[] board = [
                "XXX",
                "XOO",
                "OO "];
            bool exp = false;
            bool res = alg.ValidTicTacToe(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            string[] board = [
                "OOO",
                "OXX",
                "XX "];
            bool exp = true;
            bool res = alg.ValidTicTacToe(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase07()
        {
            string[] board = [
                "XOX",
                "OOX",
                "XO "];
            bool exp = true;
            bool res = alg.ValidTicTacToe(board);
            Assert.AreEqual(exp, res);
        }

    }
}
