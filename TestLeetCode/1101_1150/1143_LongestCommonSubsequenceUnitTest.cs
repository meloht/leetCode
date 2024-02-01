using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1143_LongestCommonSubsequenceUnitTest
    {
        _1143_LongestCommonSubsequenceAlg alg = new _1143_LongestCommonSubsequenceAlg();
        [TestMethod]
        public void TestCase01()
        {
            string text1 = "abcde", text2 = "ace";
            int exp = 3;

            int res = alg.LongestCommonSubsequence(text1, text2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string text1 = "abc", text2 = "abc";
            int exp = 3;

            int res = alg.LongestCommonSubsequence(text1, text2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string text1 = "abc", text2 = "def";
            int exp = 0;

            int res = alg.LongestCommonSubsequence(text1, text2);
            Assert.AreEqual(exp, res);
        }
    }
}
