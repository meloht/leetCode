using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _664_StrangePrinterTest
    {
        _664_StrangePrinterAlg alg = new _664_StrangePrinterAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "aaabbb";
            int exp = 2;
            int res = alg.StrangePrinter(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "aba";
            int exp = 2;
            int res = alg.StrangePrinter(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "tbgtgb";
            int exp = 4;
            int res = alg.StrangePrinter(s);
            Assert.AreEqual(exp, res);
        }
    }
}
