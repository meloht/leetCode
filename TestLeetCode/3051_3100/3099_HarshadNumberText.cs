using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3051_3100
{
    [TestClass]
    public class _3099_HarshadNumberText
    {
        _3099_HarshadNumberAlg alg = new _3099_HarshadNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int x = 18;
            int exp = 9;
            int res = alg.SumOfTheDigitsOfHarshadNumber(x);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int x = 23;
            int exp = -1;
            int res = alg.SumOfTheDigitsOfHarshadNumber(x);
            Assert.AreEqual(exp, res);
        }
    }
}
