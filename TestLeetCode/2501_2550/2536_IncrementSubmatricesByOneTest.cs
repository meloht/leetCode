using leetCode._2501_2550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2501_2550
{
    [TestClass]
    public class _2536_IncrementSubmatricesByOneTest
    {
        _2536_IncrementSubmatricesByOneAlg alg = new _2536_IncrementSubmatricesByOneAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3;
            int[][] queries = [[1, 1, 2, 2], [0, 0, 1, 1]];
            int[][] exp = [[1, 1, 0], [1, 2, 1], [0, 1, 1]];
            int[][] res = alg.RangeAddQueries(n, queries);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 2;
            int[][] queries = [[0, 0, 1, 1]];
            int[][] exp = [[1, 1], [1, 1]];
            int[][] res = alg.RangeAddQueries(n, queries);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }
    }
}
