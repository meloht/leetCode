using leetCode._0601_0650;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _623_AddOneRowToTreeTest
    {
        _623_AddOneRowToTreeAlg alg = new _623_AddOneRowToTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [4, 2, 6, 3, 1, 5];
            int val = 1, depth = 2;
            int?[] exp = [4, 1, 1, 2, null, null, 6, 3, 1, 5];
            TreeNode node=TreeNode.BuildTree(root);
            var res = alg.AddOneRow(node, val, depth);
            int?[] rees=TreeNode.GetTreeLevelList(node);

            Assert.IsTrue(exp.SequenceEqual(rees));
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [4, 2, null, 3, 1];
            int val = 1, depth = 3;
            int?[] exp = [4, 2, null, 1, 1, 3, null, null, 1];
            TreeNode node = TreeNode.BuildTree(root);
            var res = alg.AddOneRow(node, val, depth);
            int?[] rees = TreeNode.GetTreeLevelList(node);

            Assert.IsTrue(exp.SequenceEqual(rees));
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [4, 2, 6, 3, 1, 5];
            int val = 1, depth = 1;
            int?[] exp = [1, 4, null, 2, 6, 3, 1, 5];
            TreeNode node = TreeNode.BuildTree(root);
            var res = alg.AddOneRow(node, val, depth);
            int?[] rees = TreeNode.GetTreeLevelList(node);

            Assert.IsTrue(exp.SequenceEqual(rees));
        }
    }
}
