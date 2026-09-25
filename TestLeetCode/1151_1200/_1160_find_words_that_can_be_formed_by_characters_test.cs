using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1151_1200
{
    [TestClass]
    public class _1160_find_words_that_can_be_formed_by_characters_test
    {
        _1160_find_words_that_can_be_formed_by_characters alg = new _1160_find_words_that_can_be_formed_by_characters();

        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["cat", "bt", "hat", "tree"];
            string chars = "atach";
            int exp = 6;
            int res = alg.CountCharacters(words, chars);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["hello", "world", "leetcode"];
            string chars = "welldonehoneyr";
            int exp = 10;
            int res = alg.CountCharacters(words, chars);
            Assert.AreEqual(exp, res);
        }
    }
}
