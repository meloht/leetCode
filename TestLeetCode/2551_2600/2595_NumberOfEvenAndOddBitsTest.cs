using leetCode._2551_2600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2551_2600
{
    [TestClass]
    public class _2595_NumberOfEvenAndOddBitsTest
    {
        _2595_NumberOfEvenAndOddBitsAlg alg = new _2595_NumberOfEvenAndOddBitsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 17;
            int[] exp = [2, 0];
            int[] res = alg.EvenOddBit(n);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 2;
            int[] exp = [0, 1];
            int[] res = alg.EvenOddBit(n);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
