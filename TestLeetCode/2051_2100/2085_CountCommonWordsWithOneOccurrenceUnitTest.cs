using leetCode._2051_2100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2051_2100
{
    [TestClass]
    public class _2085_CountCommonWordsWithOneOccurrenceUnitTest
    {
        _2085_CountCommonWordsWithOneOccurrenceAlg alg = new _2085_CountCommonWordsWithOneOccurrenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] words1 = ["leetcode", "is", "amazing", "as", "is"];
            string[] words2 = ["amazing", "leetcode", "is"];
            int exp = 2;
            int res = alg.CountWords(words1, words2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words1 = ["b", "bb", "bbb"];
            string[] words2 = ["a", "aa", "aaa"];
            int exp = 0;
            int res = alg.CountWords(words1, words2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] words1 = ["a", "ab"];
            string[] words2 = ["a", "a", "a", "ab"];
            int exp = 1;
            int res = alg.CountWords(words1, words2);
            Assert.AreEqual(exp, res);
        }
    }
}
