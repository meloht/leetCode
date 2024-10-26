using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _526_BeautifulArrangementTest
    {
        _526_BeautifulArrangementAlg alg = new _526_BeautifulArrangementAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            int exp = 2;
            int res = alg.CountArrangement(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            int exp = 1;
            int res = alg.CountArrangement(n);
            Assert.AreEqual(exp, res);
        }
    }
}
