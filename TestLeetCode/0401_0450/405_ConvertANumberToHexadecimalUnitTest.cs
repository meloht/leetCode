using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _405_ConvertANumberToHexadecimalUnitTest
    {
        _405_ConvertANumberToHexadecimalAlg alg = new _405_ConvertANumberToHexadecimalAlg();

        [TestMethod]
        public void TestCase01()
        {
            int num = 26;
            string exp = "1a";
            string res = alg.ToHex(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int num = -1;
            string exp = "ffffffff";
            string res = alg.ToHex(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int num = -2147483648;
            string exp = "80000000";
            string res = alg.ToHex(num);
            Assert.AreEqual(exp, res);
        }
    }
}
