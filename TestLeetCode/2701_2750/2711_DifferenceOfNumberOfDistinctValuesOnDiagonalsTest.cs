using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2711_DifferenceOfNumberOfDistinctValuesOnDiagonalsTest
    {
        _2711_DifferenceOfNumberOfDistinctValuesOnDiagonalsAlg alg = new _2711_DifferenceOfNumberOfDistinctValuesOnDiagonalsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[1, 2, 3], [3, 1, 5], [3, 2, 1]];
            int[][] exp = [[1, 1, 0], [1, 0, 1], [0, 1, 1]];
            int[][] res = alg.DifferenceOfDistinctValues(grid);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[1]];
            int[][] exp = [[0]];
            int[][] res = alg.DifferenceOfDistinctValues(grid);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }
    }
}
