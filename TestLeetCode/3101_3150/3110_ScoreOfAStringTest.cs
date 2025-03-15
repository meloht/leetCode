using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3110_ScoreOfAStringTest
    {
        _3110_ScoreOfAStringAlg alg = new _3110_ScoreOfAStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "hello";
            int exp = 13;
            int res = alg.ScoreOfString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "zaz";
            int exp = 50;
            int res = alg.ScoreOfString(s);
            Assert.AreEqual(exp, res);
        }
    }
}
