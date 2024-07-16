using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _464_CanIWinTest
    {
        _464_CanIWinAlg alg = new _464_CanIWinAlg();

        [TestMethod]
        public void TestCase01()
        {
            int maxChoosableInteger = 10, desiredTotal = 11;
            bool exp = false;
            bool res = alg.CanIWin(maxChoosableInteger, desiredTotal);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int maxChoosableInteger = 10, desiredTotal = 0;
            bool exp = true;
            bool res = alg.CanIWin(maxChoosableInteger, desiredTotal);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int maxChoosableInteger = 10, desiredTotal = 1;
            bool exp = true;
            bool res = alg.CanIWin(maxChoosableInteger, desiredTotal);
            Assert.AreEqual(exp, res);
        }
    }
}
