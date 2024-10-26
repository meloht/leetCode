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
    public class _538_ConvertBstToGreaterTreeTest
    {
        _538_ConvertBstToGreaterTreeAlg alg = new _538_ConvertBstToGreaterTreeAlg();


        [TestMethod]
        public void TestCase01()
        {
            int?[] arr = [4, 1, 6, 0, 2, 5, 7, null, null, null, 3, null, null, null, 8];
            TreeNode root = TreeNode.BuildTree(arr);
            int?[] exp = [30, 36, 21, 36, 35, 26, 15, null, null, null, 33, null, null, null, 8];
            TreeNode res = alg.ConvertBST(root);
            int?[] resArr = TreeNode.GetTreeLevelList(res);
            Assert.IsTrue(exp.SequenceEqual(resArr));
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] arr = [0, null, 1];
            TreeNode root = TreeNode.BuildTree(arr);
            int?[] exp = [1, null, 1];
            TreeNode res = alg.ConvertBST(root);
            int?[] resArr = TreeNode.GetTreeLevelList(res);
            Assert.IsTrue(exp.SequenceEqual(resArr));
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] arr = [1, 0, 2];
            TreeNode root = TreeNode.BuildTree(arr);
            int?[] exp = [3, 3, 2];
            TreeNode res = alg.ConvertBST(root);
            int?[] resArr = TreeNode.GetTreeLevelList(res);
            Assert.IsTrue(exp.SequenceEqual(resArr));
        }

        [TestMethod]
        public void TestCase04()
        {
            int?[] arr = [3, 2, 4, 1];
            TreeNode root = TreeNode.BuildTree(arr);
            int?[] exp = [7, 9, 4, 10];
            TreeNode res = alg.ConvertBST(root);
            int?[] resArr = TreeNode.GetTreeLevelList(res);
            Assert.IsTrue(exp.SequenceEqual(resArr));
        }
    }
}
