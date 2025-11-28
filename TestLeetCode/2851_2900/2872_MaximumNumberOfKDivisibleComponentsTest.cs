using leetCode._2851_2900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2851_2900
{
    [TestClass]
    public class _2872_MaximumNumberOfKDivisibleComponentsTest
    {
        _2872_MaximumNumberOfKDivisibleComponentsAlg alg = new _2872_MaximumNumberOfKDivisibleComponentsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 5;
            int[][] edges = [[0, 2], [1, 2], [1, 3], [2, 4]];
            int[] values = [1, 8, 1, 4, 4];
            int k = 6;
            int exp = 2;
            int res = alg.MaxKDivisibleComponents(n, edges, values, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 7;
            int[][] edges = [[0, 1], [0, 2], [1, 3], [1, 4], [2, 5], [2, 6]];
            int[] values = [3, 0, 6, 1, 5, 2, 1];
            int k = 3;
            int exp = 3;
            int res = alg.MaxKDivisibleComponents(n, edges, values, k);
            Assert.AreEqual(exp, res);
        }
    }
}
