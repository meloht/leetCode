using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _238_ProductOfArrayExceptSelfUnitTest
    {
        _238_ProductOfArrayExceptSelfAlg alg = new _238_ProductOfArrayExceptSelfAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4];
            int[] exp = [24, 12, 8, 6];

            int[] res = alg.ProductExceptSelf(nums);

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [-1, 1, 0, -3, 3];
            int[] exp = [0, 0, 9, 0, 0];

            int[] res = alg.ProductExceptSelf(nums);

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
