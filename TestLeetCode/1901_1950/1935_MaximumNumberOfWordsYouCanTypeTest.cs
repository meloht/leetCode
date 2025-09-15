using leetCode._1901_1950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Test._1901_1950
{
    [TestClass]
    public class _1935_MaximumNumberOfWordsYouCanTypeTest
    {
        _1935_MaximumNumberOfWordsYouCanTypeAlg alg = new _1935_MaximumNumberOfWordsYouCanTypeAlg();

        [TestMethod]
        public void Test01()
        {
            string text = "hello world", brokenLetters = "ad";
            int exp = 1;
            int res = alg.CanBeTypedWords(text, brokenLetters);

            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void Test02()
        {
            string text = "leet code", brokenLetters = "lt";
            int exp = 1;
            int res = alg.CanBeTypedWords(text, brokenLetters);

            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            string text = "leet code", brokenLetters = "e";
            int exp = 0;
            int res = alg.CanBeTypedWords(text, brokenLetters);

            Assert.AreEqual(exp, res);
        }
    }
}
