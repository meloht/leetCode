using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _389_FindTheDifferenceUnitTest
    {
        _389_FindTheDifferenceAlg alg = new _389_FindTheDifferenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abcd", t = "abcde";
            char exp = 'e';
            var res = alg.FindTheDifference(s, t);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "", t = "y";
            char exp = 'y';
            var res = alg.FindTheDifference(s, t);
            Assert.AreEqual(exp, res);
        }
    }
}
