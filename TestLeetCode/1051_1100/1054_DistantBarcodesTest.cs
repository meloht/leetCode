using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1051_1100
{
    [TestClass]
    public class _1054_DistantBarcodesTest
    {
        _1054_DistantBarcodesAlg alg = new _1054_DistantBarcodesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] barcodes = [1, 1, 1, 2, 2, 2];
            int[] exp = [2, 1, 2, 1, 2, 1];
            int[] res = alg.RearrangeBarcodes(barcodes);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] barcodes = [1, 1, 1, 1, 2, 2, 3, 3];
            int[] exp = [2, 1, 2, 1, 3, 1, 3, 1];
            int[] res = alg.RearrangeBarcodes(barcodes);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] barcodes = [1, 1, 2];
            int[] exp = [1, 2, 1];
            int[] res = alg.RearrangeBarcodes(barcodes);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] barcodes = [2, 2, 1, 3];
            int[] exp = [1,2,3,2];
            int[] res = alg.RearrangeBarcodes(barcodes);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
