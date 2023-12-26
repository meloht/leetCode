using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0001_0050
{
    [TestClass]
    public class _44_WildcardMatchingUnitTest
    {
        _44_WildcardMatchingAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _44_WildcardMatchingAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var s = "aa";
            var p = "a";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            var s = "aa";
            var p = "aa";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            var s = "aa";
            var p = "*";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            var s = "cb";
            var p = "?a";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestCase05()
        {
            var s = "aaaabcd";
            var p = "a*bcd";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            var s = "aaaabcd";
            var p = "a*b*";
      
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase07()
        {
            var s = "aaaabcd";
            var p = "a*bc*";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase08()
        {
            var s = "aaaabcd";
            var p = "a*b*cd";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase09()
        {
            var s = "aaaabcad";
            var p = "a*b*c?d";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase10()
        {
            var s = "aaaabcaad";
            var p = "a*b*ca?d";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase11()
        {
            var s = "ab";
            var p = "?*";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }


        [TestMethod]
        public void TestCase12()
        {
            var s = "abcabczzzde";
            var p = "*abc???de*";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }


        [TestMethod]
        public void TestCase13()
        {
            var s = "b";
            var p = "?*?";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(false, res);
        }


        [TestMethod]
        public void TestCase14()
        {
            var s = "ho";
            var p = "**ho";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase15()
        {
            var s = "abcede";
            var p = "abc*d";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase16()
        {
            var s = "";
            var p = "******";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase17()
        {
            var s = "mississippi";
            var p = "m*iss*iss*";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase18()
        {
            var s = "c";
            var p = "*?*";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase19()
        {
            var s = "ab";
            var p = "*a";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestCase20()
        {
            var s = "ab";
            var p = "**";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase21()
        {
            var s = "baaabbabbbaabbbbbbabbbaaabbaabbbbbaaaabbbbbabaaaaabbabbaabaaababaabaaabaaaabbabbbaabbbbbaababbbabaaabaabaaabbbaababaaabaaabaaaabbabaabbbabababbbbabbaaababbabbaabbaabbbbabaaabbababbabababbaabaabbaaabbba";
            var p = "*b*ab*bb***abba*a**ab***b*aaa*a*b****a*b*bb**b**ab*ba**bb*bb*baab****bab*bbb**a*a*aab*b****b**ba**abba";
            var res = alg.IsMatch(s, p);
          
        }
        [TestMethod]
        public void TestCase22()
        {
            var s = "leetcode";
            var p = "*e*t?d*";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase23()
        {
            var s = "mississippi";
            var p = "m*si*";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase24()
        {
            var s = "babaaababaabababbbbbbaabaabbabababbaababbaaabbbaaab";
            var p = "***bba**a*bbba**aab**b";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase25()
        {
            var s = "abbabaaabbabbaababbabbbbbabbbabbbabaaaaababababbbabababaabbababaabbbbbbaaaabababbbaabbbbaabbbbababababbaabbaababaabbbababababbbbaaabbbbbabaaaabbababbbbaababaabbababbbbbababbbabaaaaaaaabbbbbaabaaababaaaabb";
            var p = "**aa*****ba*a*bb**aa*ab****a*aaaaaa***a*aaaa**bbabb*b*b**aaaaaaaaa*a********ba*bbb***a*ba*bb*bb**a*b*bb";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(false, res);

        }
    }
}
