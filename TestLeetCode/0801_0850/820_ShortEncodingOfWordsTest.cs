using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _820_ShortEncodingOfWordsTest
    {
        _820_ShortEncodingOfWordsAlg alg = new _820_ShortEncodingOfWordsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["time", "me", "bell"];
            int exp = 10;
            int res = alg.MinimumLengthEncoding(words);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["t"];
            int exp = 2;
            int res = alg.MinimumLengthEncoding(words);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] words = ["me", "time"];
            int exp = 5;
            int res = alg.MinimumLengthEncoding(words);
            Assert.AreEqual(exp, res);
        }
    }
}
