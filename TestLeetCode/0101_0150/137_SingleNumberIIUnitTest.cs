using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _137_SingleNumberIIUnitTest
    {
        _137_SingleNumberIIAlg alg = new _137_SingleNumberIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 2, 3, 2];
            int res = alg.SingleNumber(nums);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0, 1, 0, 1, 0, 1, 99];
            int res = alg.SingleNumber(nums);
            Assert.AreEqual(99, res);
        }
    }
}
