using leetCode._2601_2650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2601_2650
{
    [TestClass]
    public class _2639_FindTheWidthOfColumnsOfAGridUnitTest
    {
        _2639_FindTheWidthOfColumnsOfAGridAlg alg = new _2639_FindTheWidthOfColumnsOfAGridAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[1], [22], [333]];
            int[] exp = [3];
            int[] res = alg.FindColumnWidth(grid);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[-15, 1, 3], [15, 7, 12], [5, 6, -2]];
            int[] exp = [3, 1, 2];
            int[] res = alg.FindColumnWidth(grid);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
