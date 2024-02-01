using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0151_0200
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

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [-2, 3, -4];
            int res = alg.MaxProduct(nums);
            Assert.AreEqual(24, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [7, -2, -4];
            int res = alg.MaxProduct(nums);
            Assert.AreEqual(56, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums = [3, -1, 4];
            int res = alg.MaxProduct(nums);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            int[] nums = [2, -5, -2, -4, 3];
            int res = alg.MaxProduct(nums);
            Assert.AreEqual(24, res);
        }
    }
}
