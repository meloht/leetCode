using leetCode._1451_1500;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1451_1500
{
    [TestClass]
    public class _1486_XorOperationInAnArrayUnitTest
    {
        _1486_XorOperationInAnArrayAlg alg = new _1486_XorOperationInAnArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 5, start = 0;
            int exp = 8;
            int res = alg.XorOperation(n, start);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 4, start = 3;
            int exp = 8;
            int res = alg.XorOperation(n, start);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 1, start = 7;
            int exp = 7;
            int res = alg.XorOperation(n, start);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 10, start = 5;
            int exp = 2;
            int res = alg.XorOperation(n, start);
            Assert.AreEqual(exp, res);
        }
    }
}
