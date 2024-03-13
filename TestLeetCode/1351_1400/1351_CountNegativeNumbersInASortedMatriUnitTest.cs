using leetCode._1351_1400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1351_1400
{
    [TestClass]
    public class _1351_CountNegativeNumbersInASortedMatriUnitTest
    {
        _1351_CountNegativeNumbersInASortedMatriAlg alg = new _1351_CountNegativeNumbersInASortedMatriAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [
                [4, 3, 2, -1],
                [3, 2, 1, -1],
                [1, 1, -1, -2],
                [-1, -1, -2, -3]];
            int exp = 8;
            int res = alg.CountNegatives(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[3, 2], [1, 0]];
            int exp = 0;
            int res = alg.CountNegatives(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [4, 2, 1, -1, -2];
            int exp = 3;
            int res = alg.BinarySearch(nums);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [4, 2, 1, 1, 1, -1, -2];
            int exp = 5;
            int res = alg.BinarySearch(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
