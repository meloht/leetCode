using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1006_ClumsyFactorialTest
    {
        _1006_ClumsyFactorialAlg alg = new _1006_ClumsyFactorialAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 4;
            int exp = 7;
            int res = alg.Clumsy(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 10;
            int exp = 12;
            int res = alg.Clumsy(n);
            Assert.AreEqual(exp, res);
        }
    }
}
