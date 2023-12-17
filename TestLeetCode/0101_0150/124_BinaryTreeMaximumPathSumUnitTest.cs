using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _124_BinaryTreeMaximumPathSumUnitTest
    {
        _124_BinaryTreeMaximumPathSumAlg alg = new _124_BinaryTreeMaximumPathSumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] arr = [1, 2, 3];
            var tree = Utils.BuildTree(arr);
            int res = alg.MaxPathSum(tree);
            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] arr = [-10, 9, 20, null, null, 15, 7];
            var tree = Utils.BuildTree(arr);
            int res = alg.MaxPathSum(tree);
            Assert.AreEqual(42, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] arr = [1, -2, -3, 1, 3, -2, null, -1];
            var tree = Utils.BuildTree(arr);
            int res = alg.MaxPathSum(tree);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int?[] arr = [5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1];
            var tree = Utils.BuildTree(arr);
            int res = alg.MaxPathSum(tree);
            Assert.AreEqual(48, res);
        }

    }
}
