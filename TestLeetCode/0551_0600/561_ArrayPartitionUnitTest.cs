using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _561_ArrayPartitionUnitTest
    {
        _561_ArrayPartitionAlg alg = new _561_ArrayPartitionAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 4, 3, 2];
            int exp = 4;
            int res = alg.ArrayPairSum(nums);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [6, 2, 6, 5, 1, 2];
            int exp = 9;
            int res = alg.ArrayPairSum(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
