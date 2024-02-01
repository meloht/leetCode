using leetCode._2351_2400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2351_2400
{
    [TestClass]
    public class _2397_MaximumRowsCoveredByColumnsUnitTest
    {
        _2397_MaximumRowsCoveredByColumnsAlg alg = new _2397_MaximumRowsCoveredByColumnsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] matrix = [[0, 0, 0], [1, 0, 1], [0, 1, 1], [0, 0, 1]];
            int numSelect = 2;
            int exp = 3;
            int res = alg.MaximumRows(matrix, numSelect);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] matrix = [[1], [0]];
            int numSelect = 1;
            int exp = 2;
            int res = alg.MaximumRows(matrix, numSelect);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] matrix = [[1, 0, 1, 1, 1, 1], [0, 0, 0, 1, 1, 0], [1, 1, 0, 0, 0, 0], [0, 0, 1, 1, 0, 1]];
            int numSelect = 2;
            int exp = 1;
            int res = alg.MaximumRows(matrix, numSelect);
            Assert.AreEqual(exp, res);
        }
    }
}
