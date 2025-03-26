using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _835_ImageOverlapTest
    {
        _835_ImageOverlapAlg alg = new _835_ImageOverlapAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] img1 = [[1, 1, 0], [0, 1, 0], [0, 1, 0]], img2 = [[0, 0, 0], [0, 1, 1], [0, 0, 1]];
            int exp = 3;
            int res = alg.LargestOverlap(img1, img2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] img1 = [[1]], img2 = [[1]];
            int exp = 1;
            int res = alg.LargestOverlap(img1, img2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] img1 = [[0]], img2 = [[0]];
            int exp = 0;
            int res = alg.LargestOverlap(img1, img2);
            Assert.AreEqual(exp, res);
        }
    }
}
