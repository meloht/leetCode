using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _136_SingleNumberUnitTest
    {
        _136_SingleNumberAlg alg = new _136_SingleNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 2, 1];
            int res = alg.SingleNumber(nums);
            Assert.AreEqual(1, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [4, 1, 2, 1, 2];
            int res = alg.SingleNumber(nums);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1];
            int res = alg.SingleNumber(nums);
            Assert.AreEqual(1, res);
        }
    }
}
