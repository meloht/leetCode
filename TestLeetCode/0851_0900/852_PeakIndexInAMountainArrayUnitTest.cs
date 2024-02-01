using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _852_PeakIndexInAMountainArrayUnitTest
    {
        _852_PeakIndexInAMountainArrayAlg alg = new _852_PeakIndexInAMountainArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [0, 1, 0];
            int exp = 1;
            int res = alg.PeakIndexInMountainArray(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [0, 2, 1, 0];
            int exp = 1;
            int res = alg.PeakIndexInMountainArray(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [0, 10, 5, 2];
            int exp = 1;
            int res = alg.PeakIndexInMountainArray(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] arr = [3, 5, 3, 2, 0];
            int exp = 1;
            int res = alg.PeakIndexInMountainArray(arr);
            Assert.AreEqual(exp, res);
        }
    }
}
