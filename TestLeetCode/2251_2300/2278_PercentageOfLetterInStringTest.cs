using leetCode._2251_2300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2251_2300
{
    [TestClass]
    public class _2278_PercentageOfLetterInStringTest
    {
        _2278_PercentageOfLetterInStringAlg alg = new _2278_PercentageOfLetterInStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "foobar";
            char letter = 'o';
            int exp = 33;
            int res = alg.PercentageLetter(s, letter);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "jjjj";
            char letter = 'k';
            int exp = 0;
            int res = alg.PercentageLetter(s, letter);
            Assert.AreEqual(exp, res);
        }
    }
}
