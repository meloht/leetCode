using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0001_0050
{
    [TestClass]
    public class _35_SearchInsertPositionUnitTest
    {
        SearchInsertPositionAlg alg = new SearchInsertPositionAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[] nums = { 1, 3, 5, 6 };
            var index = alg.SearchInsert(nums, 5);

            Assert.AreEqual(2, index);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = { 1, 3, 5, 6 };
            var index = alg.SearchInsert(nums, 2);

            Assert.AreEqual(1, index);

        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = { 1, 3, 5, 6 };
            var index = alg.SearchInsert(nums, 7);

            Assert.AreEqual(4, index);

        }
        [TestMethod]
        public void TestCase04()
        {
            int[] nums = { 1, 3, 5, 6, 9 };
            var index = alg.SearchInsert(nums, 7);

            Assert.AreEqual(4, index);

        }
    }
}
