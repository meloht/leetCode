using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _219_ContainsDuplicateIIUnitTest
    {
        _219_ContainsDuplicateIIAlg alg = new _219_ContainsDuplicateIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 1];
            int k = 3;
            bool res = alg.ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 0, 1, 1];
            int k = 1;
            bool res = alg.ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 3, 1, 2, 3];
            int k = 2;
            bool res = alg.ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(false, res);
        }
    }
}
