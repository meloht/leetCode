using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _318_MaximumProductOfWordLengthsUnitTest
    {
        _318_MaximumProductOfWordLengthsAlg alg = new _318_MaximumProductOfWordLengthsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["abcw", "baz", "foo", "bar", "xtfn", "abcdef"];
            int exp = 16;
            int res = alg.MaxProduct(words);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["a", "ab", "abc", "d", "cd", "bcd", "abcd"];
            int exp = 4;
            int res = alg.MaxProduct(words);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] words = ["a", "aa", "aaa", "aaaa"];
            int exp = 0;
            int res = alg.MaxProduct(words);
            Assert.AreEqual(exp, res);
        }
    }
}
