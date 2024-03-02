using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _338_CountingBitsUnitTest
    {
        _338_CountingBitsAlg alg = new _338_CountingBitsAlg();
        
        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            int[] exp = [0, 1, 1];
            int[] res = alg.CountBits(n);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 5;
            int[] exp = [0, 1, 1, 2, 1, 2];
            int[] res = alg.CountBits(n);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

    }
}
