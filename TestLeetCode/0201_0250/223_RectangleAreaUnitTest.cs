using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _223_RectangleAreaUnitTest
    {
        _223_RectangleAreaAlg alg = new _223_RectangleAreaAlg();

        [TestMethod]
        public void TestCase01()
        {
            int ax1 = -3, ay1 = 0, ax2 = 3, ay2 = 4, bx1 = 0, by1 = -1, bx2 = 9, by2 = 2;
            int exp = 45;
            int res = alg.ComputeArea(ax1, ay1, ax2, ay2, bx1, by1, bx2, by2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int ax1 = -2, ay1 = -2, ax2 = 2, ay2 = 2, bx1 = -2, by1 = -2, bx2 = 2, by2 = 2;
            int exp = 16;
            int res = alg.ComputeArea(ax1, ay1, ax2, ay2, bx1, by1, bx2, by2);
            Assert.AreEqual(exp, res);
        }


    }
}
