using leetCode._3601_3650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3601_3650
{
    public class _3623_CountNumberOfTrapezoidsITest
    {
        _3623_CountNumberOfTrapezoidsIAlg alg = new _3623_CountNumberOfTrapezoidsIAlg();

        [Fact]
        public void Test1()
        {
            int[][] points = [[1, 0], [2, 0], [3, 0], [2, 2], [3, 2]];
            int exp = 3;
            int res = alg.CountTrapezoids(points);
            Assert.Equal(exp, res);
        }
        [Fact]
        public void Test2()
        {
            int[][] points = [[0, 0], [1, 0], [0, 1], [2, 1]];
            int exp = 1;
            int res = alg.CountTrapezoids(points);
            Assert.Equal(exp, res);
        }
    }
}
