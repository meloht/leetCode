using leetCode._2251_2300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2251_2300
{
    [TestClass]
    public class _2264_Largest3SameDigitNumberInStringTest
    {
        _2264_Largest3SameDigitNumberInStringAlg alg = new _2264_Largest3SameDigitNumberInStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string num = "6777133339";
            string exp = "777";
            string res = alg.LargestGoodInteger(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string num = "2300019";
            string exp = "000";
            string res = alg.LargestGoodInteger(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string num = "42352338";
            string exp = "";
            string res = alg.LargestGoodInteger(num);
            Assert.AreEqual(exp, res);
        }
    }
}
