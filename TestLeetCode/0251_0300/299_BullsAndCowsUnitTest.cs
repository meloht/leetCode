using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _299_BullsAndCowsUnitTest
    {
        _299_BullsAndCowsAlg alg = new _299_BullsAndCowsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string secret = "1807", guess = "7810";
            string exp = "1A3B";
            string res = alg.GetHint(secret, guess);
            Assert.AreEqual(exp, res);  
        }
        [TestMethod]
        public void TestCase02()
        {
            string secret = "1123", guess = "0111";
            string exp = "1A1B";
            string res = alg.GetHint(secret, guess);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string secret = "1122", guess = "1222";
            string exp = "3A0B";
            string res = alg.GetHint(secret, guess);
            Assert.AreEqual(exp, res);
        }
    }
}
