using leetCode._3501_3550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3501_3550
{
    public class _3531_CountCoveredBuildingsTest
    {
        _3531_CountCoveredBuildingsAlg alg = new _3531_CountCoveredBuildingsAlg();

        [Fact]
        public void Test1()
        {
            int n = 3;
            int[][] buildings = [[1, 2], [2, 2], [3, 2], [2, 1], [2, 3]];
            int exp = 1;
            int res = alg.CountCoveredBuildings(n, buildings);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int n = 3;
            int[][] buildings = [[1, 1], [1, 2], [2, 1], [2, 2]];
            int exp = 0;
            int res = alg.CountCoveredBuildings(n, buildings);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test3()
        {
            int n = 5;
            int[][] buildings = [[1, 3], [3, 2], [3, 3], [3, 5], [5, 3]];
            int exp = 1;
            int res = alg.CountCoveredBuildings(n, buildings);
            Assert.Equal(exp, res);
        }
    }
}
