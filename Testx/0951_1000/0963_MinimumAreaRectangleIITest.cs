using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0963_MinimumAreaRectangleIITest
    {
        _0963_MinimumAreaRectangleIIAlg alg = new _0963_MinimumAreaRectangleIIAlg();

        [Fact]
        public void Test01()
        {
            int[][] points=[[1, 2], [2, 1], [1, 0], [0, 1]];
            double exp = 2.0;
            double res = alg.MinAreaFreeRect(points);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[][] points = [[0, 1], [2, 1], [1, 1], [1, 0], [2, 0]];
            double exp = 1.0;
            double res = alg.MinAreaFreeRect(points);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[][] points = [[0, 3], [1, 2], [3, 1], [1, 3], [2, 1]];
            double exp = 0;
            double res = alg.MinAreaFreeRect(points);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int[][] points = [[3, 1], [1, 1], [0, 1], [2, 1], [3, 3], [3, 2], [0, 2], [2, 3]];
            double exp = 2.0;
            double res = alg.MinAreaFreeRect(points);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test05()
        {
            int[][] points = [[0, 40000], [40000, 0], [0, 0], [40000, 40000]];
            double exp = 1600000000.0;
            double res = alg.MinAreaFreeRect(points);
            Assert.Equal(exp, res);
        }
    }
}
