using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _81_SearchInRotatedSortedArrayIIUnitTest
    {
        _81_SearchInRotatedSortedArrayIIAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _81_SearchInRotatedSortedArrayIIAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = { 2, 5, 6, 0, 0, 1, 2 };

            var res = alg.Search(arr, 0);

            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = { 2, 5, 6, 0, 0, 1, 2 };

            var res = alg.Search(arr, 3);

            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1 };

            var res = alg.Search(arr, 2);

            Assert.AreEqual(true, res);
        }
    }
}
