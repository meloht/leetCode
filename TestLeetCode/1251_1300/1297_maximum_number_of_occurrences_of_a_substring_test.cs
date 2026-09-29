using leetCode._1251_1300;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1251_1300
{
    [TestClass]
    public class _1297_maximum_number_of_occurrences_of_a_substring_test
    {
        _1297_maximum_number_of_occurrences_of_a_substring alg = new _1297_maximum_number_of_occurrences_of_a_substring();

        [TestMethod]
        public void Test01()
        {
            string s = "aababcaab";
            int maxLetters = 2, minSize = 3, maxSize = 4;
            int exp = 2;
            int res = alg.MaxFreq(s,maxLetters,minSize,maxSize);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void Test02()
        {
            string s = "aaaa";
            int maxLetters = 1, minSize = 3, maxSize = 3;
            int exp = 2;
            int res = alg.MaxFreq(s, maxLetters, minSize, maxSize);
            Assert.AreEqual(exp, res);

        }
        [TestMethod]
        public void Test03()
        {
            string s = "aabcabcab";
            int maxLetters = 2, minSize = 2, maxSize = 3;
            int exp = 3;
            int res = alg.MaxFreq(s, maxLetters, minSize, maxSize);
            Assert.AreEqual(exp, res);

        }
        [TestMethod]
        public void Test04()
        {
            string s = "abcde";
            int maxLetters = 2, minSize = 3, maxSize = 3;
            int exp = 3;
            int res = alg.MaxFreq(s, maxLetters, minSize, maxSize);
            Assert.AreEqual(exp, res);
        }
    }
}
