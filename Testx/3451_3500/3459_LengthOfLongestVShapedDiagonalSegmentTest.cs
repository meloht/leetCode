using leetCode._3451_3500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3451_3500
{
    public class _3459_LengthOfLongestVShapedDiagonalSegmentTest
    {
        _3459_LengthOfLongestVShapedDiagonalSegmentAlg alg = new _3459_LengthOfLongestVShapedDiagonalSegmentAlg();

        [Fact]
        public void Test01()
        {
            int[][] grid = [[2, 2, 1, 2, 2], [2, 0, 2, 2, 0], [2, 0, 1, 1, 0], [1, 0, 2, 2, 2], [2, 0, 0, 2, 2]];
            int exp = 5;
            int res = alg.LenOfVDiagonal(grid);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[][] grid = [[2, 2, 2, 2, 2], [2, 0, 2, 2, 0], [2, 0, 1, 1, 0], [1, 0, 2, 2, 2], [2, 0, 0, 2, 2]];
            int exp = 4;
            int res = alg.LenOfVDiagonal(grid);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[][] grid = [[1, 2, 2, 2, 2], [2, 2, 2, 2, 0], [2, 0, 0, 0, 0], [0, 0, 2, 2, 2], [2, 0, 0, 2, 0]];
            int exp = 5;
            int res = alg.LenOfVDiagonal(grid);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int[][] grid = [[1]];
            int exp = 1;
            int res = alg.LenOfVDiagonal(grid);
            Assert.Equal(exp, res);
        }
    }
}
