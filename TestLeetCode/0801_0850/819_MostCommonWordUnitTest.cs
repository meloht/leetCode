using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _819_MostCommonWordUnitTest
    {
        _819_MostCommonWordAlg alg = new _819_MostCommonWordAlg();
        [TestMethod]
        public void TestCase01()
        {
            string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string[] banned = ["hit"];

            string exp = "ball";

            string res = alg.MostCommonWord(paragraph, banned);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string paragraph = "a.";
            string[] banned = [];

            string exp = "a";

            string res = alg.MostCommonWord(paragraph, banned);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            string paragraph = "a, a, a, a, b,b,b,c, c";
            string[] banned = ["a"];

            string exp = "b";

            string res = alg.MostCommonWord(paragraph, banned);
            Assert.AreEqual(exp, res);
        }
    }
}
