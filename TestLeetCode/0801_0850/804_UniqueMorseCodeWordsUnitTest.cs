using leetCode._0751_0800;
using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _804_UniqueMorseCodeWordsUnitTest
    {
        _804_UniqueMorseCodeWordsAlg alg = new _804_UniqueMorseCodeWordsAlg();
        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["gin", "zen", "gig", "msg"];
            int exp = 2;
            int res = alg.UniqueMorseRepresentations(words);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["a"];
            int exp = 1;
            int res = alg.UniqueMorseRepresentations(words);
            Assert.AreEqual(exp, res);
        }
    }
}
