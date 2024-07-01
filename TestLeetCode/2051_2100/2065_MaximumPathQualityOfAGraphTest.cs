using leetCode._2051_2100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2051_2100
{
    [TestClass]
    public class _2065_MaximumPathQualityOfAGraphTest
    {
        _2065_MaximumPathQualityOfAGraphAlg alg = new _2065_MaximumPathQualityOfAGraphAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] values = [0, 32, 10, 43];
            int[][] edges = [[0, 1, 10], [1, 2, 15], [0, 3, 10]];
            int maxTime = 49;
            int exp = 75;
            int res = alg.MaximalPathQuality(values,edges,maxTime);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] values = [5, 10, 15, 20];
            int[][] edges = [[0, 1, 10], [1, 2, 10], [0, 3, 10]];
            int maxTime = 30;
            int exp = 25;
            int res = alg.MaximalPathQuality(values, edges, maxTime);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] values = [1, 2, 3, 4];
            int[][] edges = [[0, 1, 10], [1, 2, 11], [2, 3, 12], [1, 3, 13]];
            int maxTime = 50;
            int exp = 7;
            int res = alg.MaximalPathQuality(values, edges, maxTime);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] values = [0, 1, 2];
            int[][] edges = [[1, 2, 10]];
            int maxTime = 10;
            int exp = 0;
            int res = alg.MaximalPathQuality(values, edges, maxTime);
            Assert.AreEqual(exp, res);
        }
    }
}
