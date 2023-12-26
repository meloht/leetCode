using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _153_FindMinimumInRotatedSortedArrayUnitTest
    {
        _153_FindMinimumInRotatedSortedArrayAlg alg = new _153_FindMinimumInRotatedSortedArrayAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 4, 5, 1, 2];
            int res = alg.FindMin(nums);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [4, 5, 6, 7, 0, 1, 2];
            int res = alg.FindMin(nums);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [11, 13, 15, 17];
            int res = alg.FindMin(nums);
            Assert.AreEqual(11, res);
        }
    }
}
