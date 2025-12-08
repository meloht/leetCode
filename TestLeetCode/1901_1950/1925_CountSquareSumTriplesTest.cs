using leetCode._1901_1950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1901_1950
{
    [TestClass]
    public class _1925_CountSquareSumTriplesTest
    {
        _1925_CountSquareSumTriplesAlg alg = new _1925_CountSquareSumTriplesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 5;
            int exp = 2;
            int res = alg.CountTriples(n);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int n = 10;
            int exp = 4;
            int res = alg.CountTriples(n);
            Assert.AreEqual(exp, res);
        }
    }
}
