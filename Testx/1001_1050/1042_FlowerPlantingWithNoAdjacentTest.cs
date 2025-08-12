using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1042_FlowerPlantingWithNoAdjacentTest
    {
        _1042_FlowerPlantingWithNoAdjacentAlg alg = new _1042_FlowerPlantingWithNoAdjacentAlg();

        [Fact]
        public void Test1()
        {
            int n = 3;
            int[][] paths = [[1, 2], [2, 3], [3, 1]];
            int[] exp = [1, 2, 3];
            int[] res = alg.GardenNoAdj(n, paths);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int n = 4;
            int[][] paths = [[1, 2], [3, 4]];
            int[] exp = [1, 2, 1, 2];
            int[] res = alg.GardenNoAdj(n, paths);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test3()
        {
            int n = 4;
            int[][] paths = [[1, 2], [2, 3], [3, 4], [4, 1], [1, 3], [2, 4]];
            int[] exp = [1, 2, 1, 2];
            int[] res = alg.GardenNoAdj(n, paths);
            Assert.Equal(exp, res);
        }
    }
}
