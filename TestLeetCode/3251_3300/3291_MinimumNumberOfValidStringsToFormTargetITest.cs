using leetCode._3251_3300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3251_3300
{
    [TestClass]
    public class _3291_MinimumNumberOfValidStringsToFormTargetITest
    {
        _3291_MinimumNumberOfValidStringsToFormTargetIAlg alg = new _3291_MinimumNumberOfValidStringsToFormTargetIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["abc", "aaaaa", "bcdef"];
            string target = "aabcdabc";
            int exp = 3;
            int res = alg.MinValidStrings(words, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["abababab", "ab"];
            string target = "ababaababa";
            int exp = 2;
            int res = alg.MinValidStrings(words, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] words = ["abcdef"];
            string target = "xyz";
            int exp = -1;
            int res = alg.MinValidStrings(words, target);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase04()
        {
            string[] words = ["abbbbbbabbbbbaaaaababaabbbbababbbbabbabbabaaabbbabbababababbbbbabbaaaabaaaaabb", "aaaabaabaab", "abbbbaabaaaabbabbbabaababbababbaabbaaaabbbbabb", "abbabbabababaabaaaabbaaabbbaaabaaababbbbabbaababbbabbbabbbaabaaaaaaabbbbbbbbaabbbbbbabbbaaabaabbbabbbaababaaaabbabbabaaaaabaaaababbbaaabbbabbbababbaabbbabbbababaaaababbababbaaabaaabaaabbbbbbbbabbabaaabababbbaabababbbbbaaaabaaabaaabbaaaabbbaababaababaababbbbaabaaaababbbbababaaababaababbaababbaaaaabbaababbbbbbbbababbbbbabaababbbbabbaababbbbbbaabaaabbabbabababbaaaabaaaabaaabaaaabaaaabaabbaaababbbbbbabaaababbaabbabbabababaaaaabaabaababaaababbbabbabaaaabbabbbaabbaabbbbbbbabbbabbabbbaabbbbbaabbbbabaabaabbbaaaabaababaabaabaabbbaabaaabbbaabbabbbbbaaabbabaabbbabbbbbabbaabaababbaabbaaaabaaaabbababbabbababaabbbaaaabbaaaaaaabaaabb", "aabbbbabaaaaababbababbabbbbaabbaaabbaabbbaabbabababaabaaabbabbaaaaaaababaaaaabbabbbaababab", "aaaaaabbbbbbaaab", "bbaabaa", "bbbbbbaabbaaaabbaaaabbbabbbbaaaabbabbb", "aaaaabbbabaaabbababaabbaaaaabababaaaabaabbabbbbbabaababbaabababbbbbaaabbbbaaabaabbabaabababbbb", "babbababbbaabbbababbababbbaaa"];
            string target = "aabbbbabaabbabbbabbaaaaaaaaabbabbbaaaaaabbbaabbbbb";
            int exp = 9;
            int res = alg.MinValidStrings(words, target);
            Assert.AreEqual(exp, res);
        }
    }
}
