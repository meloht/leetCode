using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _220_ContainsDuplicateIIIUnitTest
    {
        _220_ContainsDuplicateIIIAlg alg = new _220_ContainsDuplicateIIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 1];
            int indexDiff = 3, valueDiff = 0;
            bool exp = true;
            bool res = alg.ContainsNearbyAlmostDuplicate(nums, indexDiff, valueDiff);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 5, 9, 1, 5, 9];
            int indexDiff = 2, valueDiff = 3;
            bool exp = false;
            bool res = alg.ContainsNearbyAlmostDuplicate(nums, indexDiff, valueDiff);
        }
    }
}
