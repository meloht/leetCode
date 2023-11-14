using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._1_50
{
    [TestClass]
    public class _34_FindFirstAndLastPositionOfElementInSortedArrayUnitTest
    {
        FindFirstAndLastPositionOfElementInSortedArrayAlg alg = new FindFirstAndLastPositionOfElementInSortedArrayAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            var index = alg.SearchRange(nums, 8);
            if (index[0] != 3 || index[1] != 4)
            {
                Assert.Fail();
            }

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            var index = alg.SearchRange(nums, 6);
            if (index[0] != -1 || index[1] != -1)
            {
                Assert.Fail();
            }

        }
        [TestMethod]
        public void TestCase03()
        {
            int[] nums = { };
            var index = alg.SearchRange(nums, 6);
            if (index[0] != -1 || index[1] != -1)
            {
                Assert.Fail();
            }

        }
    }
}
