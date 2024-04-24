using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1025_DivisorGameUnitTest
    {
        _1025_DivisorGameAlg alg = new _1025_DivisorGameAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            bool exp = true;
            bool res = alg.DivisorGame(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 3;
            bool exp = false;
            bool res = alg.DivisorGame(n);
            Assert.AreEqual(exp, res);
        }
    }
}
