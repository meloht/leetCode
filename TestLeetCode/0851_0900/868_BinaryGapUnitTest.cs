using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _868_BinaryGapUnitTest
    {
        _868_BinaryGapAlg alg = new _868_BinaryGapAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 22;
            int exp = 2;
            int res = alg.BinaryGap(n);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int n = 8;
            int exp = 0;
            int res = alg.BinaryGap(n);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int n = 5;
            int exp = 2;
            int res = alg.BinaryGap(n);
            Assert.AreEqual(exp, res);
        }
    }
}
