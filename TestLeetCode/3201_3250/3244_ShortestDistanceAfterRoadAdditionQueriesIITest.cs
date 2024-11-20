using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3244_ShortestDistanceAfterRoadAdditionQueriesIITest
    {
        _3244_ShortestDistanceAfterRoadAdditionQueriesIIAlg alg = new _3244_ShortestDistanceAfterRoadAdditionQueriesIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 5;
            int[][] queries = [[2, 4], [0, 2], [0, 4]];
            int[] exp = [3, 2, 1];
            int[] res = alg.ShortestDistanceAfterQueries(n, queries);
            bool bl = Utils.IsSameArr(exp, res);

            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 4;
            int[][] queries = [[0, 3], [0, 2]];
            int[] exp = [1, 1];
            int[] res = alg.ShortestDistanceAfterQueries(n, queries);
            bool bl = Utils.IsSameArr(exp, res);

            Assert.IsTrue(bl);
        }
    }
}
