using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _397_IntegerReplacementUnitTest
    {
        _397_IntegerReplacementAlg alg = new _397_IntegerReplacementAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 8;
            int exp = 3;
            int res = alg.IntegerReplacement(n);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int n = 7;
            int exp = 4;
            int res = alg.IntegerReplacement(n);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            int n = 4;
            int exp = 2;
            int res = alg.IntegerReplacement(n);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int n = 65535;
            int exp = 17;
            int res = alg.IntegerReplacement(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int n = int.MaxValue;
            int exp = 17;
            int res = alg.IntegerReplacement(n);
            Assert.AreEqual(1, 1);
        }
    }
}
