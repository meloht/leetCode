using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _754_ReachANumberTest
    {
        _754_ReachANumberAlg alg = new _754_ReachANumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int target = 2;
            int exp = 3;
            int res = alg.ReachNumber(target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int target = 3;
            int exp = 2;
            int res = alg.ReachNumber(target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int target = 4;
            int exp = 3;
            int res = alg.ReachNumber(target);
            Assert.AreEqual(exp, res);
        }
    }
}
