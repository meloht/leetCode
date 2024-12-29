using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _672_BulbSwitcherIITest
    {
        _672_BulbSwitcherIIAlg alg = new _672_BulbSwitcherIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 1, presses = 1;
            int exp = 2;
            int res = alg.FlipLights(n, presses);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 2, presses = 1;
            int exp = 3;
            int res = alg.FlipLights(n, presses);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 3, presses = 1;
            int exp = 4;
            int res = alg.FlipLights(n, presses);
            Assert.AreEqual(exp, res);

        }

    }
}
