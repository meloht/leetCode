using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _343_IntegerBreakUnitTest
    {
        _343_IntegerBreakAlg alg = new _343_IntegerBreakAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            int exp = 1;
            int res = alg.IntegerBreak(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 10;
            int exp = 36;
            int res = alg.IntegerBreak(n);
            Assert.AreEqual(exp, res);
        }
    }
}
