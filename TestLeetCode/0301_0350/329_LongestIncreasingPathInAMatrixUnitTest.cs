using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _329_LongestIncreasingPathInAMatrixUnitTest
    {
        _329_LongestIncreasingPathInAMatrixAlg alg = new _329_LongestIncreasingPathInAMatrixAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] matrix = [[9, 9, 4], [6, 6, 8], [2, 1, 1]];
            int exp = 4;
            int res = alg.LongestIncreasingPath(matrix);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] matrix = [[3, 4, 5], [3, 2, 6], [2, 2, 1]];
            int exp = 4;
            int res = alg.LongestIncreasingPath(matrix);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] matrix = [[1]];
            int exp = 1;
            int res = alg.LongestIncreasingPath(matrix);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase04()
        {
            int[][] matrix = [
                [1, 4, 7, 9], 
                [0, 3, 8, 5], 
                [3, 6, 0, 6], 
                [1, 4, 5, 6]];
            int exp = 5;
            int res = alg.LongestIncreasingPath(matrix);
            Assert.AreEqual(exp, res);
        }
    }
}
