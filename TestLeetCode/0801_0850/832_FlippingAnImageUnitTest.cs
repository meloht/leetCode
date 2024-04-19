using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _832_FlippingAnImageUnitTest
    {
        _832_FlippingAnImageAlg alg = new _832_FlippingAnImageAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] image = [[1, 1, 0], [1, 0, 1], [0, 0, 0]];
            int[][] exp = [[1, 0, 0], [0, 1, 0], [1, 1, 1]];
            int[][] res = alg.FlipAndInvertImage(image);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] image = [[1, 1, 0, 0], [1, 0, 0, 1], [0, 1, 1, 1], [1, 0, 1, 0]];
            int[][] exp = [[1, 1, 0, 0], [0, 1, 1, 0], [0, 0, 0, 1], [1, 0, 1, 0]];
            int[][] res = alg.FlipAndInvertImage(image);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
