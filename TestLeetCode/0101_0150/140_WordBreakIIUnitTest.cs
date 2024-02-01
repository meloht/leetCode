using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _140_WordBreakIIUnitTest
    {
        _140_WordBreakIIAlg alg = new _140_WordBreakIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string word = "catsanddog";
            string[] wordDict = ["cat", "cats", "and", "sand", "dog"];

            var res = alg.WordBreak(word, wordDict);
            var resarr = res.ToArray();
            string[] exp = ["cats and dog", "cat sand dog"];
            Array.Sort(exp);
            Array.Sort(resarr);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string word = "catsandog";
            string[] wordDict = ["cats", "dog", "sand", "and", "cat"];

            var res = alg.WordBreak(word, wordDict);
            string[] exp = [];
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
