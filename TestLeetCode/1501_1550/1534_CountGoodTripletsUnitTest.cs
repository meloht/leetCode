using leetCode._1501_1550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1501_1550
{
    [TestClass]
    public class _1534_CountGoodTripletsUnitTest
    {
        _1534_CountGoodTripletsAlg alg = new _1534_CountGoodTripletsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [3, 0, 1, 1, 9, 7];
            int a = 7, b = 2, c = 3;
            int exp = 4;
            int res = alg.CountGoodTriplets(arr, a, b, c);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, 1, 2, 2, 3];
            int a = 0, b = 0, c = 1;
            int exp = 0;
            int res = alg.CountGoodTriplets(arr, a, b, c);
            Assert.AreEqual(exp, res);
        }
    }
}
