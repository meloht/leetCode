using leetCode._3251_3300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3251_3300
{
    [TestClass]
    public class _3297_CountSubstringsThatCanBeRearrangedToContainAStringITest
    {
        _3297_CountSubstringsThatCanBeRearrangedToContainAStringIAlg alg = new _3297_CountSubstringsThatCanBeRearrangedToContainAStringIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string word1 = "bcca", word2 = "abc";
            long exp = 1;
            long res = alg.ValidSubstringCount(word1, word2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string word1 = "abcabc", word2 = "abc";
            long exp = 10;
            long res = alg.ValidSubstringCount(word1, word2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string word1 = "abcabc", word2 = "aaabc";
            long exp = 0;
            long res = alg.ValidSubstringCount(word1, word2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string word1 = "dcbdcdccb", word2 = "cdd";
            long exp = 18;
            long res = alg.ValidSubstringCount(word1, word2);
            Assert.AreEqual(exp, res);
        }
    }
}
