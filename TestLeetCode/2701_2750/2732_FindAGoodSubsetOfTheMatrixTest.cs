using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2732_FindAGoodSubsetOfTheMatrixTest
    {
        _2732_FindAGoodSubsetOfTheMatrixAlg alg = new _2732_FindAGoodSubsetOfTheMatrixAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[0, 1, 1, 0], [0, 0, 0, 1], [1, 1, 1, 1]];
            int[] exp = [0, 1];
            int[] res = alg.GoodSubsetofBinaryMatrix(grid).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[0]];
            int[] exp = [0];
            int[] res = alg.GoodSubsetofBinaryMatrix(grid).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[1, 1, 1], [1, 1, 1]];
            int[] exp = [];
            int[] res = alg.GoodSubsetofBinaryMatrix(grid).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
