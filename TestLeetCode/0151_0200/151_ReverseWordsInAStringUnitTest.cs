using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _151_ReverseWordsInAStringUnitTest
    {
        _151_ReverseWordsInAStringAlg alg = new _151_ReverseWordsInAStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "the sky is blue";
            var res = alg.ReverseWords(s);
            string exp = "blue is sky the";
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            string s = "  hello world  ";
            var res = alg.ReverseWords(s);
            string exp = "world hello";
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            string s = "a good   example";
            var res = alg.ReverseWords(s);
            string exp = "example good a";
            Assert.AreEqual(exp, res);
        }
    }
}
