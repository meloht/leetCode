using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _762_PrimeNumberOfSetBitsInBinaryRepresentationUnitTest
    {
        _762_PrimeNumberOfSetBitsInBinaryRepresentationAlg alg = new _762_PrimeNumberOfSetBitsInBinaryRepresentationAlg();
        [TestMethod]
        public void TestCase01()
        {
            int left = 6, right = 10;
            int exp = 4;
            int res = alg.CountPrimeSetBits(left, right);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int left = 10, right = 15;
            int exp = 5;
            int res = alg.CountPrimeSetBits(left, right);
            Assert.AreEqual(exp, res);
        }
    }
}
