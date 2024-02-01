using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0151_0200
{
    [TestClass]
    public class _164_MaximumGapUnitTest
    {
        _164_MaximumGapAlg alg = new _164_MaximumGapAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 6, 9, 1];
            int res = alg.MaximumGap(nums);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [10];
            int res = alg.MaximumGap(nums);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 10000000];
            int res = alg.MaximumGap(nums);
            Assert.AreEqual(9999999, res);
        }
    }
}
