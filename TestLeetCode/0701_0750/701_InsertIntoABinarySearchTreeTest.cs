using leetCode._0701_0750;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _701_InsertIntoABinarySearchTreeTest
    {
        _701_InsertIntoABinarySearchTreeAlg alg = new _701_InsertIntoABinarySearchTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [4, 2, 7, 1, 3];
            int val = 5;
            int?[] exp = [4, 2, 7, 1, 3, 5];

            TreeNode node = TreeNode.BuildTree(root);
            TreeNode res = alg.InsertIntoBST(node, val);
            int?[] ress = TreeNode.GetTreeLevelList(node);
            Assert.IsTrue(exp.SequenceEqual(ress));
        }


        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [40, 20, 60, 10, 30, 50, 70];
            int val = 25;
            int?[] exp = [40, 20, 60, 10, 30, 50, 70, null, null, 25];

            TreeNode node = TreeNode.BuildTree(root);
            TreeNode res = alg.InsertIntoBST(node, val);
            int?[] ress = TreeNode.GetTreeLevelList(node);
            Assert.IsTrue(exp.SequenceEqual(ress));
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [4, 2, 7, 1, 3, null, null, null, null, null, null];
            int val = 5;
            int?[] exp = [4, 2, 7, 1, 3, 5];

            TreeNode node = TreeNode.BuildTree(root);
            TreeNode res = alg.InsertIntoBST(node, val);
            int?[] ress = TreeNode.GetTreeLevelList(node);
            Assert.IsTrue(exp.SequenceEqual(ress));
        }
    }
}
