using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _378_KthSmallestElementInASortedMatrixUnitTest
    {
        _378_KthSmallestElementInASortedMatrixAlg alg = new _378_KthSmallestElementInASortedMatrixAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] matrix = [
                [1, 5, 9], 
                [10, 11, 13], 
                [12, 13, 15]];
            int k = 8;
            int exp = 13;
            int res = alg.KthSmallest(matrix, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] matrix = [[-5]];
            int k = 1;
            int exp = -5;
            int res = alg.KthSmallest(matrix, k);
            Assert.AreEqual(exp, res);
        }
    }
}
