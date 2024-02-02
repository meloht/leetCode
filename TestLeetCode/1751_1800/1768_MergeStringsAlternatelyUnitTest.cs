using leetCode._1751_1800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1751_1800
{
    [TestClass]
    public class _1768_MergeStringsAlternatelyUnitTest
    {
        _1768_MergeStringsAlternatelyAlg alg = new _1768_MergeStringsAlternatelyAlg();

        [TestMethod]
        public void TestCase01()
        {
            string word1 = "abc", word2 = "pqr";
            string exp = "apbqcr";
            string res = alg.MergeAlternately(word1, word2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string word1 = "ab", word2 = "pqrs";
            string exp = "apbqrs";
            string res = alg.MergeAlternately(word1, word2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string word1 = "abcd", word2 = "pq";
            string exp = "apbqcd";
            string res = alg.MergeAlternately(word1, word2);
            Assert.AreEqual(exp, res);
        }
    }
}
