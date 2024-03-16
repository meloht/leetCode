using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _264_UglyNumberIIUnitTest
    {
        _264_UglyNumberIIAlg alg = new _264_UglyNumberIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 10;
            int exp = 12;
            int res = alg.NthUglyNumber(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            int exp = 1;
            int res = alg.NthUglyNumber(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 1690;
            int exp = 1;
            int res = alg.NthUglyNumber(n);
           // Assert.AreEqual(exp, res);
        }

    }
}
