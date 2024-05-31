using leetCode._2951_3000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2951_3000
{
    [TestClass]
    public class _2965_FindMissingAndRepeatedValuesUnitTest
    {
        _2965_FindMissingAndRepeatedValuesAlg alg = new _2965_FindMissingAndRepeatedValuesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[1, 3], [2, 2]];
            int[] exp = [2, 4];
            int[] res = alg.FindMissingAndRepeatedValues(grid);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[9, 1, 7], [8, 9, 2], [3, 4, 6]];
            int[] exp = [9, 5];
            int[] res = alg.FindMissingAndRepeatedValues(grid);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
