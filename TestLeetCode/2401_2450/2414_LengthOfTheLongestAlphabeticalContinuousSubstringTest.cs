using leetCode._2401_2450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2401_2450
{
    [TestClass]
    public class _2414_LengthOfTheLongestAlphabeticalContinuousSubstringTest
    {
        _2414_LengthOfTheLongestAlphabeticalContinuousSubstringAlg alg = new _2414_LengthOfTheLongestAlphabeticalContinuousSubstringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abacaba";
            int exp = 2;
            int res = alg.LongestContinuousSubstring(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abcde";
            int exp = 5;
            int res = alg.LongestContinuousSubstring(s);
            Assert.AreEqual(exp, res);
        }
    }
}
