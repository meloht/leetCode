using leetCode._0851_0900;
using leetCode.WeeklyContest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _859_BuddyStringsUnitTest
    {
        _859_BuddyStringsAlg alg = new _859_BuddyStringsAlg();
        [TestMethod]
        public void TestCase01()
        {
            string s = "ab", goal = "ba";
            bool exp = true;
            bool res = alg.BuddyStrings(s, goal);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "ab", goal = "ab";
            bool exp = false;
            bool res = alg.BuddyStrings(s, goal);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "aa", goal = "aa";
            bool exp = true;
            bool res = alg.BuddyStrings(s, goal);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "abcd", goal = "badc";
            bool exp = false;
            bool res = alg.BuddyStrings(s, goal);
            Assert.AreEqual(exp, res);
        }
    }
}
