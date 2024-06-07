using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _395_LongestSubstringWithAtLeastKRepeatingCharactersUnitTest
    {
        _395_LongestSubstringWithAtLeastKRepeatingCharactersAlg alg = new _395_LongestSubstringWithAtLeastKRepeatingCharactersAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "aaabb";
            int k = 3;
            int exp = 3;
            int res = alg.LongestSubstring(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "ababbc";
            int k = 2;
            int exp = 5;
            int res = alg.LongestSubstring(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "ababacb";
            int k = 3;
            int exp = 0;
            int res = alg.LongestSubstring(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "weitong";
            int k = 2;
            int exp = 0;
            int res = alg.LongestSubstring(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string s = "baaabcb";
            int k = 3;
            int exp = 3;
            int res = alg.LongestSubstring(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            string s = "aacbbbdc";
            int k = 2;
            int exp = 3;
            int res = alg.LongestSubstring(s, k);
            Assert.AreEqual(exp, res);
        }
    }
}
