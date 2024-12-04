using leetCode._2051_2100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2051_2100
{
    [TestClass]
    public class _2056_NumberOfValidMoveCombinationsOnChessboardTest
    {
        _2056_NumberOfValidMoveCombinationsOnChessboardAlg alg = new _2056_NumberOfValidMoveCombinationsOnChessboardAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] pieces = ["rook"];
            int[][] positions = [[1, 1]];
            int exp = 15;
            int res = alg.CountCombinations(pieces, positions);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] pieces = ["queen"];
            int[][] positions = [[1, 1]];
            int exp = 22;
            int res = alg.CountCombinations(pieces, positions);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] pieces = ["bishop"];
            int[][] positions = [[4, 3]];
            int exp = 12;
            int res = alg.CountCombinations(pieces, positions);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string[] pieces = ["rook", "rook"];
            int[][] positions = [[1, 1], [8, 8]];
            int exp = 223;
            int res = alg.CountCombinations(pieces, positions);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string[] pieces = ["queen", "bishop"];
            int[][] positions = [[5, 7], [3, 4]];
            int exp = 281;
            int res = alg.CountCombinations(pieces, positions);
            Assert.AreEqual(exp, res);
        }
    }
}
