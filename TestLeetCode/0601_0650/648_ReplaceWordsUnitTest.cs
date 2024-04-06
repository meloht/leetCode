using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _648_ReplaceWordsUnitTest
    {
        _648_ReplaceWordsAlg alg = new _648_ReplaceWordsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] dictionary = ["cat", "bat", "rat"];
            string sentence = "the cattle was rattled by the battery";
            string exp = "the cat was rat by the bat";
            string res = alg.ReplaceWords(dictionary, sentence);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] dictionary = ["a", "b", "c"];
            string sentence = "aadsfasf absbs bbab cadsfafs";
            string exp = "a a b c";
            string res = alg.ReplaceWords(dictionary, sentence);
            Assert.AreEqual(exp, res);
        }
    }
}
