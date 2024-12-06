using leetCode._3001_3050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3001_3050
{
    [TestClass]
    public class _3001_MinimumMovesToCaptureTheQueenTest
    {
        _3001_MinimumMovesToCaptureTheQueenAlg alg = new _3001_MinimumMovesToCaptureTheQueenAlg();

        [TestMethod]
        public void TestCase01()
        {
            int a = 1, b = 1, c = 8, d = 8, e = 2, f = 3;
            int exp = 2;
            int res = alg.MinMovesToCaptureTheQueen(a, b, c, d, e, f);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int a = 5, b = 3, c = 3, d = 4, e = 5, f = 2;
            int exp = 1;
            int res = alg.MinMovesToCaptureTheQueen(a, b, c, d, e, f);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int a = 4, b = 3, c = 3, d = 4, e = 5, f = 2;
            int exp = 2;
            int res = alg.MinMovesToCaptureTheQueen(a, b, c, d, e, f);
            Assert.AreEqual(exp, res);
        }
    }
}
