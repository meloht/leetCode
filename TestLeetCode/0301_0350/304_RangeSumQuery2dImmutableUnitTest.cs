using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _304_RangeSumQuery2dImmutableUnitTest
    {


        [TestMethod]
        public void TestCase01()
        {
            int[][] matrix = [[3, 0, 1, 4, 2], [5, 6, 3, 2, 1], [1, 2, 0, 1, 5], [4, 1, 0, 1, 7], [1, 0, 3, 0, 5]];
            _304_RangeSumQuery2dImmutableAlg.NumMatrix numMatrix = new(matrix);
            Assert.AreEqual(8, numMatrix.SumRegion(2, 1, 4, 3)); // return 8 (红色矩形框的元素总和)
            Assert.AreEqual(11, numMatrix.SumRegion(1, 1, 2, 2)); // return 11 (绿色矩形框的元素总和)
            Assert.AreEqual(12, numMatrix.SumRegion(1, 2, 2, 4)); // return 12 (蓝色矩形框的元素总和)
        }
    }
}
