using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _402_RemoveKDigitsUnitTest
    {
        _402_RemoveKDigitsAlg alg = new _402_RemoveKDigitsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string num = "1432219";
            int k = 3;
            string exp = "1219";
            string res = alg.RemoveKdigits(num, k);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            string num = "10200";
            int k = 1;
            string exp = "200";
            string res = alg.RemoveKdigits(num, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string num = "10";
            int k = 2;
            string exp = "0";
            string res = alg.RemoveKdigits(num, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string num = "112";
            int k = 1;
            string exp = "11";
            string res = alg.RemoveKdigits(num, k);
            Assert.AreEqual(exp, res);
        }
    }
}
