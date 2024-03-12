using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _476_NumberComplementUnitTest
    {
        _476_NumberComplementAlg alg = new _476_NumberComplementAlg();

        [TestMethod]
        public void TestCase01()
        {
            int num = 5;
            int exp = 2;
            int res = alg.FindComplement(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int num = 1;
            int exp = 0;
            int res = alg.FindComplement(num);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int num = int.MaxValue;
            int exp = 0;
            int res = alg.FindComplement(num);
            Assert.AreEqual(exp, res);
        }
    }
}
