using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _342_PowerOfGourUnitTest
    {
        _342_PowerOfGourAlg alg = new _342_PowerOfGourAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 16;
            bool exp = true;
            bool res = alg.IsPowerOfFour(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 5;
            bool exp = false;
            bool res = alg.IsPowerOfFour(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 1;
            bool exp = true;
            bool res = alg.IsPowerOfFour(n);
            Assert.AreEqual(exp, res);
        }
    }
}
