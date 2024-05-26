using leetCode._1701_1750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1701_1750
{
    [TestClass]
    public class _1738_FindKthLargestXorCoordinateValueUnitTest
    {
        _1738_FindKthLargestXorCoordinateValueAlg alg = new _1738_FindKthLargestXorCoordinateValueAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] matrix = [[5, 2], [1, 6]];
            int k = 1;
            int exp = 7;
            int res = alg.KthLargestValue(matrix, k);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] matrix = [[5, 2], [1, 6]];
            int k = 2;
            int exp = 5;
            int res = alg.KthLargestValue(matrix, k);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] matrix = [[5, 2], [1, 6]];
            int k = 3;
            int exp = 4;
            int res = alg.KthLargestValue(matrix, k);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] matrix = [[5, 2], [1, 6]];
            int k = 4;
            int exp = 0;
            int res = alg.KthLargestValue(matrix, k);
            Assert.AreEqual(exp, res);

        }
    }
}
