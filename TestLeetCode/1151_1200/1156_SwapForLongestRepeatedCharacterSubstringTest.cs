using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1151_1200
{
    [TestClass]
    public class _1156_SwapForLongestRepeatedCharacterSubstringTest
    {
        _1156_SwapForLongestRepeatedCharacterSubstringAlg alg = new _1156_SwapForLongestRepeatedCharacterSubstringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string text = "ababa";
            int exp = 3;
            int res = alg.MaxRepOpt1(text);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string text = "aaabaaa";
            int exp = 6;
            int res = alg.MaxRepOpt1(text);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string text = "aaabbaaa";
            int exp = 4;
            int res = alg.MaxRepOpt1(text);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string text = "aaaaa";
            int exp = 5;
            int res = alg.MaxRepOpt1(text);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string text = "abcdef";
            int exp = 1;
            int res = alg.MaxRepOpt1(text);
            Assert.AreEqual(exp, res);
        }
    }
}
