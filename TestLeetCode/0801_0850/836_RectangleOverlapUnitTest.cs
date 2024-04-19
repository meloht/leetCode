using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _836_RectangleOverlapUnitTest
    {
        _836_RectangleOverlapAlg alg = new _836_RectangleOverlapAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] rec1 = [0, 0, 2, 2], rec2 = [1, 1, 3, 3];
            bool exp = true;
            bool res = alg.IsRectangleOverlap(rec1, rec2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] rec1 = [0, 0, 1, 1], rec2 = [1, 0, 2, 1];
            bool exp = false;
            bool res = alg.IsRectangleOverlap(rec1, rec2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] rec1 = [0, 0, 1, 1], rec2 = [2, 2, 3, 3];
            bool exp = false;
            bool res = alg.IsRectangleOverlap(rec1, rec2);
            Assert.AreEqual(exp, res);
        }
    }
}
