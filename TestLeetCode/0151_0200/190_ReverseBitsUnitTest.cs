using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _190_ReverseBitsUnitTest
    {
        _190_ReverseBitsAlg alg = new _190_ReverseBitsAlg();

        [TestMethod]
        public void TestCase01()
        {
            uint n = 43261596;
            uint exp = 964176192;
            var res = alg.reverseBits(n);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            uint n = 4294967293;
            uint exp = 3221225471;
            var res = alg.reverseBits(n);
            Assert.AreEqual(exp, res);

        }

    }
}
