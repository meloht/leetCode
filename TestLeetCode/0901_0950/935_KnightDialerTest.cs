using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _935_KnightDialerTest
    {
        _935_KnightDialerAlg alg = new _935_KnightDialerAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 1;
            int exp = 10;
            int res = alg.KnightDialer(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 2;
            int exp = 20;
            int res = alg.KnightDialer(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 3131;
            int exp = 136006598;
            int res = alg.KnightDialer(n);
            Assert.AreEqual(exp, res);
        }
    }
}
