using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _593_ValidSquareTest
    {
        _593_ValidSquareAlg alg = new _593_ValidSquareAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] p1 = [0, 0], p2 = [1, 1], p3 = [1, 0], p4 = [0, 1];
            bool exp = true;
            bool res = alg.ValidSquare(p1, p2, p3, p4);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] p1 = [0, 0], p2 = [1, 1], p3 = [1, 0], p4 = [0, 12];
            bool exp = false;
            bool res = alg.ValidSquare(p1, p2, p3, p4);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] p1 = [1, 0], p2 = [-1, 0], p3 = [0, 1], p4 = [0, -1];
            bool exp = true;
            bool res = alg.ValidSquare(p1, p2, p3, p4);
            Assert.AreEqual(exp, res);
        }
    }
}
