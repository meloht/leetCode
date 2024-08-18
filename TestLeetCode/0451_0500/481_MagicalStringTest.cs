using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _481_MagicalStringTest
    {
        _481_MagicalStringAlg alg = new _481_MagicalStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 6;
            int exp = 3;
            int res = alg.MagicalString(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            int exp = 1;
            int res = alg.MagicalString(n);
            Assert.AreEqual(exp, res);
        }
    }
}
