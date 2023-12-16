using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._1_50
{
    [TestClass]
    public class _33_SearchInRotatedSortedArrayUnitTest
    {
        SearchInRotatedSortedArrayAlg alg = new SearchInRotatedSortedArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int index = alg.Search(nums, 0);
            Assert.AreEqual(index, 4);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int index = alg.Search(nums, 3);
            Assert.AreEqual(index, -1);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = { 1 };
            int index = alg.Search(nums, 0);
            Assert.AreEqual(index, -1);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int index = alg.Search(nums, 5);
            Assert.AreEqual(index, 1);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int index = alg.Search(nums, 1);
            Assert.AreEqual(index, 5);
        }

        [TestMethod]
        public void TestCase06()
        {
            int[] nums = { 3, 4, 5, 6, 1, 2 };
            int index = alg.Search(nums, 2);
            Assert.AreEqual(index, 5);
        }

        [TestMethod]
        public void TestCase07()
        {
            int[] nums = { 9, 1, 2, 3, 4, 5, 6, 7, 8 };
            int index = alg.Search(nums, 9);
            Assert.AreEqual(index, 0);
        }

        [TestMethod]
        public void TestCase08()
        {
            int[] nums = { 3, 5, 1 };
            int index = alg.Search(nums, 3);
            Assert.AreEqual(index, 0);
        }
    }
}
