using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0151_0200
{
    [TestClass]
    public class _154_FindMinimumInRotatedSortedArrayIIUnitTest
    {
        _154_FindMinimumInRotatedSortedArrayIIAlg alg = new _154_FindMinimumInRotatedSortedArrayIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, 5];
            int res = alg.FindMin(nums);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 2, 2, 0, 1];
            int res = alg.FindMin(nums);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 3, 3];
            int res = alg.FindMin(nums);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [3, 3, 1, 3];
            int res = alg.FindMin(nums);
            Assert.AreEqual(1, res);
        }
    }
}
