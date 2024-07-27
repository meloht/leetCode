using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3106_LexicographicallySmallestStringAfterOperationsWithConstraintTest
    {
        _3106_LexicographicallySmallestStringAfterOperationsWithConstraintAlg alg = new _3106_LexicographicallySmallestStringAfterOperationsWithConstraintAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "zbbz";int k = 3;
            string exp = "aaaz";
            string res = alg.GetSmallestString(s, k);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "xaxcd"; int k = 4;
            string exp = "aawcd";
            string res = alg.GetSmallestString(s, k);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "lol"; int k = 0;
            string exp = "lol";
            string res = alg.GetSmallestString(s, k);
            Assert.AreEqual(exp, res);

        }
    }
}
