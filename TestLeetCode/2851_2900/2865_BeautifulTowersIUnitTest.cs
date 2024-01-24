using leetCode._2851_2900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2851_2900
{
    [TestClass]
    public class _2865_BeautifulTowersIUnitTest
    {
        _2865_BeautifulTowersIAlg alg = new _2865_BeautifulTowersIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] maxHeights = [5, 3, 4, 1, 1];
            long exp = 13;
            var res = alg.MaximumSumOfHeights(maxHeights.ToList());
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] maxHeights = [6, 5, 3, 9, 2, 7];
            long exp = 22;
            var res = alg.MaximumSumOfHeights(maxHeights.ToList());
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] maxHeights = [3, 2, 5, 5, 2, 3];
            long exp = 18;
            var res = alg.MaximumSumOfHeights(maxHeights.ToList());
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] maxHeights = [1, 5, 2, 5, 6, 4, 6, 3, 4, 5];
            long exp = 33;
            var res = alg.MaximumSumOfHeights(maxHeights.ToList());
            Assert.AreEqual(exp, res);
        }
    }
}
