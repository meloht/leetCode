using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _939_MinimumAreaRectangleTest
    {
        _939_MinimumAreaRectangleAlg alg = new _939_MinimumAreaRectangleAlg();

        [Fact]
        public void Test01()
        {
            int[][] points = [[1, 1], [1, 3], [3, 1], [3, 3], [2, 2]];
            int exp = 4;
            int res = alg.MinAreaRect(points);
            Assert.Equal(exp, res);
        }


        [Fact]
        public void Test02()
        {
            int[][] points = [[1, 1], [1, 3], [3, 1], [3, 3], [4, 1], [4, 3]];
            int exp = 2;
            int res = alg.MinAreaRect(points);
            Assert.Equal(exp, res);
        }
        [Fact]
        public void Test03()
        {
            int[][] points = [[1, 2], [3, 2], [1, 3], [5, 5], [2, 0], [4, 5], [3, 4], [1, 4], [1, 5], [0, 0], [0, 5], [0, 4], [4, 2], [3, 5], [5, 2], [2, 4], [4, 0]];
            int exp = 1;
            int res = alg.MinAreaRect(points);
            Assert.Equal(exp, res);
        }
        [Fact]
        public void Test04()
        {
            int[][] points = [[22005, 6126], [17721, 24176], [17721, 33586], [22005, 24176], [16980, 24176], [22005, 9550], [23496, 9550], [5162, 38294], [23496, 38294], [5162, 33586], [23496, 38121], [5162, 6126], [17721, 9550], [16980, 4081], [23496, 6126], [1889, 9550], [7555, 33586], [5162, 9550], [17721, 6126], [23496, 33586], [7555, 24176], [23496, 24176], [17721, 38294], [7555, 9550], [1889, 24176], [1889, 6126], [17721, 38121], [1889, 33586], [23496, 4081], [16980, 6126]];
            int exp = 999075;
            int res = alg.MinAreaRect(points);
            Assert.Equal(exp, res);
        }
    }
}
