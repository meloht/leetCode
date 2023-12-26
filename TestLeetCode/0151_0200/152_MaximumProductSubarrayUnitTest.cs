using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _152_MaximumProductSubarrayUnitTest
    {
        _152_MaximumProductSubarrayAlg alg = new _152_MaximumProductSubarrayAlg();
        
        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 3, -2, 4];
            int res = alg.MaxProduct(nums);
            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [-2, 0, -1];
            int res = alg.MaxProduct(nums);
            Assert.AreEqual(0, res);
        }
    }
}
