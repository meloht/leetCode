using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _541_ReverseStringIIUnitTest
    {
        _541_ReverseStringIIAlg alg = new _541_ReverseStringIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abcdefg";
            int k = 2;
            string exp = "bacdfeg";
            string res = alg.ReverseStr(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abcd";
            int k = 2;
            string exp = "bacd";
            string res = alg.ReverseStr(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "abc";
            int k = 4;
            string exp = "cba";
            string res = alg.ReverseStr(s, k);
            Assert.AreEqual(exp, res);
        }
    }
}
