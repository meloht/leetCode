using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _76_MinimumWindowSubstringUnitTest
    {
        _76_MinimumWindowSubstringAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _76_MinimumWindowSubstringAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            string s = "ADOBECODEBANC";
            string t = "ABC";
            string exp = "BANC";
            var res = alg.MinWindow(s, t);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "a";
            string t = "a";
            string exp = "a";
            var res = alg.MinWindow(s, t);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "a";
            string t = "aa";
            string exp = "";
            var res = alg.MinWindow(s, t);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "abc";
            string t = "ab";
            string exp = "ab";
            var res = alg.MinWindow(s, t);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase05()
        {
            string s = "bba";
            string t = "ab";
            string exp = "ba";
            var res = alg.MinWindow(s, t);
            Assert.AreEqual(exp, res);
        }
    }
}
