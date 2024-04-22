using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0951_1000
{
    [TestClass]
    public class _0977_SquaresOfASortedArrayUnitTest
    {
        _0977_SquaresOfASortedArrayAlg alg = new _0977_SquaresOfASortedArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [-4, -1, 0, 3, 10];
            int[] exp = [0, 1, 9, 16, 100];
            int[] res = alg.SortedSquares(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [-7, -3, 2, 3, 11];
            int[] exp = [4, 9, 9, 49, 121];
            int[] res = alg.SortedSquares(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [-1];
            int[] exp = [1];
            int[] res = alg.SortedSquares(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [-1, 2, 2];
            int[] exp = [1, 4, 4];
            int[] res = alg.SortedSquares(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
