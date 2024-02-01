using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _112_PathSumUnitTest
    {
        _112_PathSumAlg alg = new _112_PathSumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2, 3];
            var tree = Utils.BuildTree(root);
            var num = alg.HasPathSum(tree, 5);
            Assert.AreEqual(false, num);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1];
            var tree = Utils.BuildTree(root);
            var num = alg.HasPathSum(tree, 22);
            Assert.AreEqual(true, num);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [];
            var tree = Utils.BuildTree(root);
            var num = alg.HasPathSum(tree, 0);
            Assert.AreEqual(false, num);
        }
    }
}
