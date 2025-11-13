using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1138_AlphabetBoardPathTest
    {
        _1138_AlphabetBoardPathAlg alg = new _1138_AlphabetBoardPathAlg();

        [TestMethod]
        public void TestCase01()
        {
            string target = "leet";
         
            string exp = "DDR!UURRR!!DDD!";
            string res = alg.AlphabetBoardPath(target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string target = "code";
            string exp = "RR!DDRR!UUL!R!";
            string res = alg.AlphabetBoardPath(target);
            Assert.AreEqual(exp, res);
        }
    }
}
