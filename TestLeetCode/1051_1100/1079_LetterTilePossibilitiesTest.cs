using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1051_1100
{
    [TestClass]
    public class _1079_LetterTilePossibilitiesTest
    {
        _1079_LetterTilePossibilitiesAlg alg = new _1079_LetterTilePossibilitiesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "AAB";
            int exp = 8;
            int res = alg.NumTilePossibilities(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "AAABBC";
            int exp = 188;
            int res = alg.NumTilePossibilities(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "V";
            int exp = 1;
            int res = alg.NumTilePossibilities(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "ADIUSIQ";
            int exp = 7012;
            int res = alg.NumTilePossibilities(s);
            Assert.AreEqual(exp, res);
        }
    }
}
