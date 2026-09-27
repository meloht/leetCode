using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1201_1250
{
    [TestClass]
    public class _1252_cells_with_odd_values_in_a_matrix_test
    {
        _1252_cells_with_odd_values_in_a_matrix alg = new();

        [TestMethod]
        public void TestCase01()
        {
            int m = 2, n = 3;
            int[][] indices = [[0, 1], [1, 1]];
            int exp = 6;
            int res = alg.OddCells(m, n, indices);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int m = 2, n = 2;
            int[][] indices = [[1, 1], [0, 0]];
            int exp = 0;
            int res = alg.OddCells(m, n, indices);
            Assert.AreEqual(exp, res);
        }
    }
}
