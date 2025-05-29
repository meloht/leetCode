using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0985_SumOfEvenNumbersAfterQueriesTest
    {
        _0985_SumOfEvenNumbersAfterQueriesAlg alg = new _0985_SumOfEvenNumbersAfterQueriesAlg();

        [Fact]
        public void Test01()
        {
            int[] A = [1, 2, 3, 4];
            int[][] queries = [[1, 0], [-3, 1], [-4, 0], [2, 3]];
            int[] exp = [8, 6, 2, 4];
            int[] res = alg.SumEvenAfterQueries(A, queries);
            Assert.Equal(exp, res);
        }

    }
}
