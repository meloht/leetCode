using leetCode._2851_2900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2851_2900
{
    [TestClass]
    public class _2864_MaximumOddBinaryNumberUnitTest
    {
        _2864_MaximumOddBinaryNumberAlg alg = new _2864_MaximumOddBinaryNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "010";
            string exp = "001";
            string res = alg.MaximumOddBinaryNumber(s);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            string s = "0101";
            string exp = "1001";
            string res = alg.MaximumOddBinaryNumber(s);
            Assert.AreEqual(exp, res);
        }
    }
}
