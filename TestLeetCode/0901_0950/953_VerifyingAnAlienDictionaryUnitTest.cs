using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _953_VerifyingAnAlienDictionaryUnitTest
    {
        _953_VerifyingAnAlienDictionaryAlg alg = new _953_VerifyingAnAlienDictionaryAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["hello", "leetcode"];
            string order = "hlabcdefgijkmnopqrstuvwxyz";
            bool exp = true;
            bool res = alg.IsAlienSorted(words, order);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["word", "world", "row"];
            string order = "worldabcefghijkmnpqstuvxyz";
            bool exp = false;
            bool res = alg.IsAlienSorted(words, order);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] words = ["apple", "app"];
            string order = "abcdefghijklmnopqrstuvwxyz";
            bool exp = false;
            bool res = alg.IsAlienSorted(words, order);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string[] words = ["kuvp", "q"];
            string order = "ngxlkthsjuoqcpavbfdermiywz";
            bool exp = true;
            bool res = alg.IsAlienSorted(words, order);
            Assert.AreEqual(exp, res);
        }
    }
}
