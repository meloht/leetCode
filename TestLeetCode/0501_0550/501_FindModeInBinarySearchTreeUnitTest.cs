using leetCode._0501_0550;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _501_FindModeInBinarySearchTreeUnitTest
    {
        _501_FindModeInBinarySearchTreeAlg alg = new _501_FindModeInBinarySearchTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, null, 2, 2];
            var tree = TreeNode.BuildTree(root);
            int[] exp = [2];
            int[] res = alg.FindMode(tree);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);

        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [0];
            var tree = TreeNode.BuildTree(root);
            int[] exp = [0];
            int[] res = alg.FindMode(tree);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);

        }
    }
}
