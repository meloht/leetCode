using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _119_PascalsTriangleIIUnitTest
    {
        _119_PascalsTriangleIIAlg alg = new _119_PascalsTriangleIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] exp = { 1, 3, 3, 1 };
            var res = alg.GetRow(3);
            Assert.AreEqual(true, exp.SequenceEqual(res));
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] exp = { 1 };
            var res = alg.GetRow(0);
            Assert.AreEqual(true, exp.SequenceEqual(res));
        }
    }
}
