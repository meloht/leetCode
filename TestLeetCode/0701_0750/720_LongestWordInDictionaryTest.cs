using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _720_LongestWordInDictionaryTest
    {
        _720_LongestWordInDictionaryAlg alg = new _720_LongestWordInDictionaryAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["w", "wo", "wor", "worl", "world"];
            string exp = "world";
            string res = alg.LongestWord(words);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["a", "banana", "app", "appl", "ap", "apply", "apple"];
            string exp = "apple";
            string res = alg.LongestWord(words);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] words = ["k", "lg", "it", "oidd", "oid", "oiddm", "kfk", "y", "mw", "kf", "l", "o", "mwaqz", "oi", "ych", "m", "mwa"];
            string exp = "oiddm";
            string res = alg.LongestWord(words);
            Assert.AreEqual(exp, res);
        }
    }
}
