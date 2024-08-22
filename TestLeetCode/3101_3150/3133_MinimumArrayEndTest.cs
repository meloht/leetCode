using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3133_MinimumArrayEndTest
    {
        _3133_MinimumArrayEndAlg alg = new _3133_MinimumArrayEndAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3, x = 4;
            long exp = 6;
            long res = alg.MinEnd(n, x);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 2, x = 7;
            long exp = 15;
            long res = alg.MinEnd(n, x);
            Assert.AreEqual(exp, res);
        }

    }
}
