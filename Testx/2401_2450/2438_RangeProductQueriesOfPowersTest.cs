using leetCode._2401_2450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2401_2450
{
    public class _2438_RangeProductQueriesOfPowersTest
    {
        _2438_RangeProductQueriesOfPowersAlg alg = new _2438_RangeProductQueriesOfPowersAlg();

        [Fact]
        public void Test1()
        {
            int n = 15;
            int[][] queries = [[0, 1], [2, 2], [0, 3]];
            int[] exp = [2, 4, 64];
            int[] res = alg.ProductQueries(n, queries);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int n = 2;
            int[][] queries = [[0, 0]];
            int[] exp = [2];
            int[] res = alg.ProductQueries(n, queries);
            Assert.Equal(exp, res);
        }
    }
}
