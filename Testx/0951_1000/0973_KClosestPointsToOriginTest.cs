using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0973_KClosestPointsToOriginTest
    {
        _0973_KClosestPointsToOriginAlg alg = new _0973_KClosestPointsToOriginAlg();
        [Fact]
        public void Test01()
        {
            int[][] points = [[1, 3], [-2, 2]];
            int k = 1;
            int[][] exp = [[-2, 2]];
            int[][] res = alg.KClosest(points, k);
            Assert.True(Utils.IsSameArr(exp, res));
        }

        [Fact]
        public void Test02()
        {
            int[][] points = [[3, 3], [5, -1], [-2, 4]];
            int k = 2;
            int[][] exp = [[3, 3], [-2, 4]];
            int[][] res = alg.KClosest(points, k);
            Assert.True(Utils.IsSame(exp, res));
        }
    }
}
