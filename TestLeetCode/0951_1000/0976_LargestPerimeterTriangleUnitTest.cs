using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0951_1000
{
    [TestClass]
    public class _0976_LargestPerimeterTriangleUnitTest
    {
        _0976_LargestPerimeterTriangleAlg alg = new _0976_LargestPerimeterTriangleAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 1, 2];
            int exp = 5;
            int res = alg.LargestPerimeter(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 1, 10];
            int exp = 0;
            int res = alg.LargestPerimeter(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [3, 6, 2, 3];
            int exp = 8;
            int res = alg.LargestPerimeter(nums);
            Assert.AreEqual(exp, res);
        }

    }
}
