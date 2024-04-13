using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _696_CountBinarySubstringsUnitTest
    {
        _696_CountBinarySubstringsAlg alg = new _696_CountBinarySubstringsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "00110011";
            int exp = 6;
            int res = alg.CountBinarySubstrings(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "10101";
            int exp = 4;
            int res = alg.CountBinarySubstrings(s);
            Assert.AreEqual(exp, res);
        }
    }
}
