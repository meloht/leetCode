using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _786_KThSmallestPrimeFractionTest
    {
        _786_KThSmallestPrimeFractionAlg alg = new _786_KThSmallestPrimeFractionAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [1, 2, 3, 5];
            int k = 3;
            int[] exp = [2, 5];
            int[] res = alg.KthSmallestPrimeFraction(arr, k);
            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, 7];
            int k = 1;
            int[] exp = [1, 7];
            int[] res = alg.KthSmallestPrimeFraction(arr, k);
            CollectionAssert.AreEqual(exp, res);
        }
    }
}
