using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _861_ScoreAfterFlippingMatrixTest
    {
        _861_ScoreAfterFlippingMatrixAlg alg = new _861_ScoreAfterFlippingMatrixAlg();

        [Fact]
        public void Test01()
        {
            int[][] grid = [[0, 0, 1, 1], [1, 0, 1, 0], [1, 1, 0, 0]];
            int exp = 39;
            int res = alg.MatrixScore(grid);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[][] grid = [[0]];
            int exp = 1;
            int res = alg.MatrixScore(grid);
            Assert.Equal(exp, res);
        }
    }
}
