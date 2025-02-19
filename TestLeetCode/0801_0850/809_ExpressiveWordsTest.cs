using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _809_ExpressiveWordsTest
    {
        _809_ExpressiveWordsAlg alg = new _809_ExpressiveWordsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string S = "heeellooo";
            string[] words = new string[] { "hello", "hi", "helo" };
            int exp = 1;
            var res = alg.ExpressiveWords(S, words);
            Assert.IsTrue(exp == res);
        }

    }
}
