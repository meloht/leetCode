using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _424_LongestRepeatingCharacterReplacementTest
    {
        _424_LongestRepeatingCharacterReplacementAlg alg = new _424_LongestRepeatingCharacterReplacementAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "ABAB";
            int k = 2;
            int exp = 4;
            int res = alg.CharacterReplacement(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "AABABBA";
            int k = 1;
            int exp = 4;
            int res = alg.CharacterReplacement(s, k);
            Assert.AreEqual(exp, res);
        }
    }
}
