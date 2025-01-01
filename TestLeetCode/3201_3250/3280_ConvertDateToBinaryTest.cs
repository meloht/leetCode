using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3280_ConvertDateToBinaryTest
    {
        _3280_ConvertDateToBinaryAlg alg = new _3280_ConvertDateToBinaryAlg();

        [TestMethod]
        public void TestCase01()
        {
            string date = "2080-02-29";
            string exp = "100000100000-10-11101";
            string res = alg.ConvertDateToBinary(date);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string date = "1900-01-01";
            string exp = "11101101100-1-1";
            string res = alg.ConvertDateToBinary(date);
            Assert.AreEqual(exp, res);
        }

       
    }
}
