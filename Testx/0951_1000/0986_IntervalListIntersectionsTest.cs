using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0986_IntervalListIntersectionsTest
    {
        _0986_IntervalListIntersectionsAlg alg = new _0986_IntervalListIntersectionsAlg();

        [Fact]
        public void Test01()
        {
            int[][] firstList = [[0, 2], [5, 10], [13, 23], [24, 25]], secondList = [[1, 5], [8, 12], [15, 24], [25, 26]];
            int[][] exp = [[1, 2], [5, 5], [8, 10], [15, 23], [24, 24], [25, 25]];
            int[][] res = alg.IntervalIntersection(firstList, secondList);
            Assert.True(Utils.IsSameArr(exp, res));
        }

        [Fact]
        public void Test02()
        {
            int[][] firstList = [[1, 3], [5, 9]], secondList = [];
            int[][] exp = [];
            int[][] res = alg.IntervalIntersection(firstList, secondList);
            Assert.True(Utils.IsSameArr(exp, res));
        }

        [Fact]
        public void Test03()
        {
            int[][] firstList = [], secondList = [[4, 8], [10, 12]];
            int[][] exp = [];
            int[][] res = alg.IntervalIntersection(firstList, secondList);
            Assert.True(Utils.IsSameArr(exp, res));
        }

        [Fact]
        public void Test04()
        {
            int[][] firstList = [[1, 7]], secondList = [[3, 10]];
            int[][] exp = [[3, 7]];
            int[][] res = alg.IntervalIntersection(firstList, secondList);
            Assert.True(Utils.IsSameArr(exp, res));
        }
    }
}
