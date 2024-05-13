using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _363_MaxSumOfRectangleNoLargerThanKUnitTest
    {
        _363_MaxSumOfRectangleNoLargerThanKAlg alg = new _363_MaxSumOfRectangleNoLargerThanKAlg();
        
        [TestMethod]
        public void TestCase01()
        {
            int[][] matrix = [[1, 0, 1], [0, -2, 3]];
            int k = 2;
            int exp = 2;
            int res = alg.MaxSumSubmatrix(matrix, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] matrix = [[2, 2, -1]];
            int k = 3;
            int exp = 3;
            int res = alg.MaxSumSubmatrix(matrix, k);
            Assert.AreEqual(exp, res);
        }
    }
}
