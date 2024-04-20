using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _884_UncommonWordsFromTwoSentencesUnitTest
    {
        _884_UncommonWordsFromTwoSentencesAlg alg = new _884_UncommonWordsFromTwoSentencesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s1 = "this apple is sweet", s2 = "this apple is sour";
            string[] exp = ["sweet", "sour"];
            string[] res = alg.UncommonFromSentences(s1, s2);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string s1 = "apple apple", s2 = "banana";
            string[] exp = ["banana"];
            string[] res = alg.UncommonFromSentences(s1, s2);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }
    }
}
