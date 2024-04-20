using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _888_FairCandySwapUnitTest
    {
        _888_FairCandySwapAlg alg = new _888_FairCandySwapAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] aliceSizes = [1, 1], bobSizes = [2, 2];
            int[] exp = [1, 2];
            int[] res = alg.FairCandySwap(aliceSizes, bobSizes);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] aliceSizes = [1, 2], bobSizes = [2, 3];
            int[] exp = [1, 2];
            int[] res = alg.FairCandySwap(aliceSizes, bobSizes);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] aliceSizes = [2], bobSizes = [1, 3];
            int[] exp = [2, 3];
            int[] res = alg.FairCandySwap(aliceSizes, bobSizes);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] aliceSizes = [1, 2, 5], bobSizes = [2, 4];
            int[] exp = [5, 4];
            int[] res = alg.FairCandySwap(aliceSizes, bobSizes);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
