using leetCode._2051_2100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2051_2100
{
    [TestClass]
    public class _2070_MostBeautifulItemForEachQueryTest
    {
        _2070_MostBeautifulItemForEachQueryAlg alg = new _2070_MostBeautifulItemForEachQueryAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] items = [[1, 2], [3, 2], [2, 4], [5, 6], [3, 5]];
            int [] queries = [1, 2, 3, 4, 5, 6];
            int[] exp = [2, 4, 5, 5, 6, 6];
            int[] res = alg.MaximumBeauty(items, queries);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] items = [[1, 2], [1, 2], [1, 3], [1, 4]];
            int[] queries = [1];
            int[] exp = [4];
            int[] res = alg.MaximumBeauty(items, queries);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] items = [[10, 1000]];
            int[] queries = [5];
            int[] exp = [0];
            int[] res = alg.MaximumBeauty(items, queries);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
