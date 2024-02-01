using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _788_RotatedDigitsUnitTest
    {
        _788_RotatedDigitsAlg alg = new _788_RotatedDigitsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int exp = 4;
            int res = alg.RotatedDigits(10);
            Assert.AreEqual(exp, res);
        }

    }
}
