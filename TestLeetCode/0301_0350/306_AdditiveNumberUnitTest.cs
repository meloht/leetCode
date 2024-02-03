using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _306_AdditiveNumberUnitTest
    {
        _306_AdditiveNumberAlg alg = new _306_AdditiveNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            string num = "112358";
            bool exp = true;
            bool res = alg.IsAdditiveNumber(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string num = "199100199";
            bool exp = true;
            bool res = alg.IsAdditiveNumber(num);
            Assert.AreEqual(exp, res);
        }
    }
}
