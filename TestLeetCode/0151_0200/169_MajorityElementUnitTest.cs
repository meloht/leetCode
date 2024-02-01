using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0151_0200
{
    [TestClass]
    public class _169_MajorityElementUnitTest
    {
        _169_MajorityElementAlg alg = new _169_MajorityElementAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 2, 3];
            int res = alg.MajorityElement(nums);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 2, 1, 1, 1, 2, 2];
            int res = alg.MajorityElement(nums);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1];
            int res = alg.MajorityElement(nums);
            Assert.AreEqual(1, res);
        }
    }
}
