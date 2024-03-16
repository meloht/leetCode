using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _540_SingleElementInASortedArrayUnitTest
    {
        _540_SingleElementInASortedArrayAlg alg = new _540_SingleElementInASortedArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 1, 2, 3, 3, 4, 4, 8, 8];
            int exp = 2;
            int res = alg.SingleNonDuplicate(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [3, 3, 7, 7, 10, 11, 11];
            int exp = 10;
            int res = alg.SingleNonDuplicate(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
