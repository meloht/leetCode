using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _205_IsomorphicStringsUnitTest
    {
        _205_IsomorphicStringsAlg alg = new _205_IsomorphicStringsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "egg", t = "add";
            var res = alg.IsIsomorphic(s, t);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "foo", t = "bar";
            var res = alg.IsIsomorphic(s, t);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "paper", t = "title";
            var res = alg.IsIsomorphic(s, t);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "badc", t = "baba";
            var res = alg.IsIsomorphic(s, t);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string s = "bbbaaaba", t = "aaabbbba";
            var res = alg.IsIsomorphic(s, t);
            Assert.AreEqual(false, res);
        }
    }
}
