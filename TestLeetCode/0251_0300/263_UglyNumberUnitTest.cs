using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _263_UglyNumberUnitTest
    {
        _263_UglyNumberAlg alg = new _263_UglyNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 6;
            bool exp = true;
            var res = alg.IsUgly(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            bool exp = true;
            var res = alg.IsUgly(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 14;
            bool exp = false;
            var res = alg.IsUgly(n);
            Assert.AreEqual(exp, res);
        }
    }
}
