using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _661_ImageSmootherUnitTest
    {
        _661_ImageSmootherAlg alg = new _661_ImageSmootherAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] img = [[1, 1, 1], [1, 0, 1], [1, 1, 1]];

            int[][] exp = [[0, 0, 0], [0, 0, 0], [0, 0, 0]];
            int[][] res = alg.ImageSmoother(img);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] img = [[100, 200, 100], [200, 50, 200], [100, 200, 100]];

            int[][] exp = [[137, 141, 137], [141, 138, 141], [137, 141, 137]];
            int[][] res = alg.ImageSmoother(img);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

    }
}
