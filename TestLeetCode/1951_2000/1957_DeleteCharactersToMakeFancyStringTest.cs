using leetCode._1951_2000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1951_2000
{
    [TestClass]
    public class _1957_DeleteCharactersToMakeFancyStringTest
    {
        _1957_DeleteCharactersToMakeFancyStringAlg alg = new _1957_DeleteCharactersToMakeFancyStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "leeetcode";
            string exp = "leetcode";
            string res = alg.MakeFancyString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "aaabaaaa";
            string exp = "aabaa";
            string res = alg.MakeFancyString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "aab";
            string exp = "aab";
            string res = alg.MakeFancyString(s);
            Assert.AreEqual(exp, res);
        }
    }
}
