using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _824_GoatLatinUnitTest
    {
        _824_GoatLatinAlg alg = new _824_GoatLatinAlg();

        [TestMethod]
        public void TestCase01()
        {
            string sentence = "I speak Goat Latin";
            string exp = "Imaa peaksmaaa oatGmaaaa atinLmaaaaa";
            string res = alg.ToGoatLatin(sentence);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            string sentence = "The quick brown fox jumped over the lazy dog";
            string exp = "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa";
            string res = alg.ToGoatLatin(sentence);
            Assert.AreEqual(exp, res);
        }
    }
}
