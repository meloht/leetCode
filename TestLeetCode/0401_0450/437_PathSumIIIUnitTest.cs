using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0401_0450
{
    [TestClass]
    public class _437_PathSumIIIUnitTest
    {
        _437_PathSumIIIAlg alg = new _437_PathSumIIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [10, 5, -3, 3, 2, null, 11, 3, -2, null, 1];
            var tree = Utils.BuildTree(root);
            int targetSum = 8;
            int exp = 3;
            int res = alg.PathSum(tree, targetSum);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1];
            var tree = Utils.BuildTree(root);
            int targetSum = 22;
            int exp = 3;
            int res = alg.PathSum(tree, targetSum);
            Assert.AreEqual(exp, res);
        }
    }
}
