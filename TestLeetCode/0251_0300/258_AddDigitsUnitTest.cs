using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _258_AddDigitsUnitTest
    {
        _258_AddDigitsAlg alg = new _258_AddDigitsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int num = 38;
            int exp = 2;
            int res = alg.AddDigits(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int num = 0;
            int exp = 0;
            int res = alg.AddDigits(num);
            Assert.AreEqual(exp, res);
        }
    }
}
