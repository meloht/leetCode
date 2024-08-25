using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _698_PartitionToKEqualSumSubsetsTest
    {
        _698_PartitionToKEqualSumSubsetsAlg alg = new _698_PartitionToKEqualSumSubsetsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 3, 2, 3, 5, 2, 1];
            int k = 4;
            bool exp = true;
            bool res = alg.CanPartitionKSubsets(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4];
            int k = 3;
            bool exp = true;
            bool res = alg.CanPartitionKSubsets(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
