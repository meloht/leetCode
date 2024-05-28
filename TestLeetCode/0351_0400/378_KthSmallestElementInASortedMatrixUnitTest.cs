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

        [TestMethod]
        public void TestCase03()
        {
            int[][] matrix = [
                [1, 2], 
                [3, 3]];
            int k = 2;
            int exp = 2;
            int res = alg.KthSmallest(matrix, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] matrix = [
                [1, 3, 5],
                [6, 7, 12],
                [11, 14, 14]];
            int k = 3;
            int exp = 5;
            int res = alg.KthSmallest(matrix, k);
            Assert.AreEqual(exp, res);
        }
    }
}
