using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _139_WordBreakUnitTest
    {
        _139_WordBreakAlg alg = new _139_WordBreakAlg();

        [TestMethod]
        public void TestCase01()
        {
            string word = "leetcode";
            string[] wordDict = ["leet", "code"];

            bool bl = alg.WordBreak(word, wordDict);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string word = "applepenapple";
            string[] wordDict = ["apple", "pen"];

            bool bl = alg.WordBreak(word, wordDict);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            string word = "catsandog";
            string[] wordDict = ["cats", "dog", "sand", "and", "cat"];

            bool bl = alg.WordBreak(word, wordDict);
            Assert.IsFalse(bl);
        }
    }
}
