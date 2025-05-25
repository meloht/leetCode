using leetCode._2101_2150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2101_2150
{
    [TestClass]
    public class _2131_LongestPalindromeByConcatenatingTwoLetterWordsTest
    {
        _2131_LongestPalindromeByConcatenatingTwoLetterWordsAlg alg = new _2131_LongestPalindromeByConcatenatingTwoLetterWordsAlg();

        [TestMethod]
        public void Test01()
        {
            string[] words = ["lc", "cl", "gg"];
            int exp = 6;
            int res = alg.LongestPalindrome(words);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            string[] words = ["ab", "ty", "yt", "lc", "cl", "ab"];
            int exp = 8;
            int res = alg.LongestPalindrome(words);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            string[] words = ["cc", "ll", "xx"];
            int exp = 2;
            int res = alg.LongestPalindrome(words);
            Assert.AreEqual(exp, res);
        }
    }
}
