﻿using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0001_0050
{
    [TestClass]
    public class _36_ValidSudokuUnitTest
    {
        _36_ValidSudokuAlg alg = new _36_ValidSudokuAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[][] board =
{ new []{'5', '3', '.', '.', '7', '.', '.', '.', '.' }
, new []{'6', '.', '.', '1', '9', '5', '.', '.', '.' }
, new []{'.', '9', '8', '.', '.', '.', '.', '6', '.'}
, new []{'8', '.', '.', '.', '6', '.', '.', '.', '3'}
, new []{'4', '.', '.', '8', '.', '3', '.', '.', '1'}
, new []{'7', '.', '.', '.', '2', '.', '.', '.', '6'}
, new []{'.', '6', '.', '.', '.', '.', '2', '8', '.'}
, new []{'.', '.', '.', '4', '1', '9', '.', '.', '5'}
, new []{'.', '.', '.', '.', '8', '.', '.', '7', '9'}};
            var index = alg.IsValidSudoku(board);

            Assert.AreEqual(true, index);

        }

        [TestMethod]
        public void TestCase02()
        {
            char[][] board =
{ new []{ '8', '3', '.', '.', '7', '.', '.', '.', '.' }
, new []{ '6', '.', '.', '1', '9', '5', '.', '.', '.' }
, new []{ '.', '9', '8', '.', '.', '.', '.', '6', '.' }
, new []{ '8', '.', '.', '.', '6', '.', '.', '.', '3' }
, new []{ '4', '.', '.', '8', '.', '3', '.', '.', '1' }
, new []{ '7', '.', '.', '.', '2', '.', '.', '.', '6' }
, new []{ '.', '6', '.', '.', '.', '.', '2', '8', '.' }
, new []{ '.', '.', '.', '4', '1', '9', '.', '.', '5' }
, new []{'.','.','.','.','8','.','.','7','9'}};

            var index = alg.IsValidSudoku(board);

            Assert.AreEqual(false, index);

        }

        [TestMethod]
        public void TestCase03()
        {
            char[][] board =
{ new []{ '.', '.', '4', '.', '.', '.', '6', '3', '.' }
, new []{ '.', '.', '.', '.', '.', '.', '.', '.', '.' }
, new []{ '5', '.', '.', '.', '.', '.', '.', '9', '.' }
, new []{ '.', '.', '.', '5', '6', '.', '.', '.', '.' }
, new []{ '4', '.', '3', '.', '.', '.', '.', '.', '1' }
, new []{ '.', '.', '.', '7', '.', '.', '.', '.', '.' }
, new []{ '.', '.', '.', '5', '.', '.', '.', '.', '.' }
, new []{ '.', '.', '.', '.', '.', '.', '.', '.', '.' }
, new []{'.','.','.','.','.','.','.','.','.'}};

            var index = alg.IsValidSudoku(board);

            Assert.AreEqual(false, index);

        }

        [TestMethod]
        public void TestCase04()
        {
            char[][] board =
{ new []{ '.', '.', '.', '1', '.', '8', '.', '.', '.' }
, new []{ '.', '.', '.', '.', '.', '.', '.', '.', '.' }
, new []{ '.', '.', '.', '.', '.', '.', '.', '.', '.' }
, new []{ '4', '.', '.', '.', '.', '7', '.', '.', '.' }
, new []{ '.', '.', '.', '7', '.', '.', '8', '4', '1' }
, new []{ '.', '.', '.', '.', '7', '.', '.', '.', '.' }
, new []{ '.', '.', '.', '.', '.', '.', '6', '.', '.' }
, new []{ '.', '.', '.', '6', '.', '.', '.', '.', '.' }
, new []{'6','.','.','.','.','.','.','.','.'}};

            var index = alg.IsValidSudoku(board);

            Assert.AreEqual(false, index);

        }
    }
}
