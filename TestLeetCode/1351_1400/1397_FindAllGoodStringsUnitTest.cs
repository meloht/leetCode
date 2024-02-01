using leetCode._1351_1400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1351_1400
{
    [TestClass]
    public class _1397_FindAllGoodStringsUnitTest
    {
        _1397_FindAllGoodStringsAlg alg = new _1397_FindAllGoodStringsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            string s1 = "aa", s2 = "da", evil = "b";
            int exp = 51;

            int res = alg.FindGoodStrings(n, s1, s2, evil);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 8;
            string s1 = "leetcode", s2 = "leetgoes", evil = "leet";
            int exp = 0;

            int res = alg.FindGoodStrings(n, s1, s2, evil);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 2;
            string s1 = "gx", s2 = "gz", evil = "x";
            int exp = 2;

            int res = alg.FindGoodStrings(n, s1, s2, evil);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 8;
            string s1 = "pzdanyao", s2 = "wgpmtywi", evil = "sdka";
            int exp = 500543753;

            int res = alg.FindGoodStrings(n, s1, s2, evil);
            Assert.AreEqual(exp, res);
        }
    }
}
