using leetCode._2951_3000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2951_3000
{
    [TestClass]
    public class _2966_DivideArrayIntoArraysWithMaxDifferenceTest
    {
        _2966_DivideArrayIntoArraysWithMaxDifferenceAlg alg = new _2966_DivideArrayIntoArraysWithMaxDifferenceAlg();

        [TestMethod]
        public void Test01()
        {
            int[] nums = [1, 3, 4, 8, 7, 9, 3, 5, 1];
            int k = 2;
            int[][] exp = [[1, 1, 3], [3, 4, 5], [7, 8, 9]];
            int[][] res = alg.DivideArray(nums,k);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }

        [TestMethod]
        public void Test02()
        {
            int[] nums = [2, 4, 2, 2, 5, 2];
            int k = 2;
            int[][] exp = [];
            int[][] res = alg.DivideArray(nums, k);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }


        [TestMethod]
        public void Test03()
        {
            int[] nums = [4, 2, 9, 8, 2, 12, 7, 12, 10, 5, 8, 5, 5, 7, 9, 2, 5, 11];
            int k = 14;
            int[][] exp = [[2, 2, 2], [4, 5, 5], [5, 5, 7], [7, 8, 8], [9, 9, 10], [11, 12, 12]];
            int[][] res = alg.DivideArray(nums, k);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }
    }
}
