using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _686_RepeatedStringMatchTest
    {
        _686_RepeatedStringMatchAlg alg = new _686_RepeatedStringMatchAlg();

        [TestMethod]
        public void TestCase01()
        {
            string a = "abcd", b = "cdabcdab";
            int exp = 3;
            int res = alg.RepeatedStringMatch(a, b);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string a = "a", b = "aa";
            int exp = 2;
            int res = alg.RepeatedStringMatch(a, b);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string a = "a", b = "a";
            int exp = 1;
            int res = alg.RepeatedStringMatch(a, b);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string a = "abc", b = "wxyz";
            int exp = -1;
            int res = alg.RepeatedStringMatch(a, b);
            Assert.AreEqual(exp, res);
        }
    }
}
