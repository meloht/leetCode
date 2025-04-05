using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _885_SpiralMatrixIIITest
    {
        _885_SpiralMatrixIIIAlg alg = new _885_SpiralMatrixIIIAlg();

        [Fact]
        public void Test01()
        {
            int rows = 1, cols = 4, rStart = 0, cStart = 0;
            int[][] exp = [[0, 0], [0, 1], [0, 2], [0, 3]];
            int[][] res = alg.SpiralMatrixIII(rows, cols, rStart, cStart);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int rows = 5, cols = 6, rStart = 1, cStart = 4;
            int[][] exp = [[1, 4], [1, 5], [2, 5], [2, 4], [2, 3], [1, 3], [0, 3], [0, 4], [0, 5], [3, 5], [3, 4], [3, 3], [3, 2], [2, 2], [1, 2], [0, 2], [4, 5], [4, 4], [4, 3], [4, 2], [4, 1], [3, 1], [2, 1], [1, 1], [0, 1], [4, 0], [3, 0], [2, 0], [1, 0], [0, 0]];
            int[][] res = alg.SpiralMatrixIII(rows, cols, rStart, cStart);
            Assert.Equal(exp, res);
        }
    }
}
