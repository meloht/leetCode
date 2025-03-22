using leetCode._2601_2650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2601_2650
{
    [TestClass]
    public class _2643_RowWithMaximumOnesTest
    {
        _2643_RowWithMaximumOnesAlg alg = new _2643_RowWithMaximumOnesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] mat = [[0, 1], [1, 0]];
            int[] exp = [0, 1];
            int[] res = alg.RowAndMaximumOnes(mat);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] mat = [[0, 0, 0], [0, 1, 1]];
            int[] exp = [1, 2];
            int[] res = alg.RowAndMaximumOnes(mat);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] mat = [[0, 0], [1, 1], [0, 0]];
            int[] exp = [1, 2];
            int[] res = alg.RowAndMaximumOnes(mat);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
