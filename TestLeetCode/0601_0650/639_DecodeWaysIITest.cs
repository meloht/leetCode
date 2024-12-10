using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _639_DecodeWaysIITest
    {
        _639_DecodeWaysIIAlg alg=new _639_DecodeWaysIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "*";
            int exp = 9;
            int res = alg.NumDecodings(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "1*";
            int exp = 18;
            int res = alg.NumDecodings(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "2*";
            int exp = 15;
            int res = alg.NumDecodings(s);
            Assert.AreEqual(exp, res);
        }
    }
}
