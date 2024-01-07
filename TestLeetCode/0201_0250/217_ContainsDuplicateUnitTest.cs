using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _217_ContainsDuplicateUnitTest
    {
        _217_ContainsDuplicateAlg alg = new _217_ContainsDuplicateAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 1];
            bool res = alg.ContainsDuplicate(nums);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4];
            bool res = alg.ContainsDuplicate(nums);
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];
            bool res = alg.ContainsDuplicate(nums);
            Assert.IsTrue(res);
        }
    }
}
