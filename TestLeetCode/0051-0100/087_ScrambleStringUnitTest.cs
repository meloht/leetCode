using leetCode;
using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._51_100
{
    [TestClass]
    public class _87_ScrambleStringUnitTest
    {
        _87_ScrambleStringAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _87_ScrambleStringAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            string s1 = "great", s2 = "rgeat";
            var res = alg.IsScramble(s1, s2);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s1 = "abcde", s2 = "caebd";
            var res = alg.IsScramble(s1, s2);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s1 = "a", s2 = "a";
            var res = alg.IsScramble(s1, s2);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s1 = "abb", s2 = "bba";
            var res = alg.IsScramble(s1, s2);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string s1 = "abcdd", s2 = "dbdac";
            var res = alg.IsScramble(s1, s2);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            string s1 = "eebaacbcbcadaaedceaaacadccd", s2 = "eadcaacabaddaceacbceaabeccd";
            var res = alg.IsScramble(s1, s2);
           // Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase07()
        {
            string s1 = "abcdbdacbdac", s2 = "bdacabcdbdac";
            var res = alg.IsScramble(s1, s2);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase08()
        {
            string s1 = "abcd", s2 = "acdb";
            var res = alg.IsScramble(s1, s2);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase09()
        {
            string s1 = "aabb", s2 = "abab";
            var res = alg.IsScramble(s1, s2);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase10()
        {
            string s1 = "ccababcaabcb", s2 = "bccbccaaabab";
            var res = alg.IsScramble(s1, s2);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase11()
        {
            string s1 = "acddaaaadbcbdcdaccabdbadccaaa", s2 = "adcbacccabbaaddadcdaabddccaaa";
            var res = alg.IsScramble(s1, s2);
            // Assert.AreEqual(false, res);
        }
    }
}
