using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _693_BinaryNumberWithAlternatingBitsUnitTest
    {
        _693_BinaryNumberWithAlternatingBitsAlg alg = new _693_BinaryNumberWithAlternatingBitsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 5;
            bool exp = true;
            bool res = alg.HasAlternatingBits(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 7;
            bool exp = false;
            bool res = alg.HasAlternatingBits(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 11;
            bool exp = false;
            bool res = alg.HasAlternatingBits(n);
            Assert.AreEqual(exp, res);
        }
    }
}
