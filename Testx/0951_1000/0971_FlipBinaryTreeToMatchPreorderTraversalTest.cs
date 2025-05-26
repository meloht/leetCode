using leetCode._0951_1000;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0971_FlipBinaryTreeToMatchPreorderTraversalTest
    {
        _0971_FlipBinaryTreeToMatchPreorderTraversalAlg alg = new _0971_FlipBinaryTreeToMatchPreorderTraversalAlg();

        [Fact]
        public void Test01()
        {
            int?[] root = [1, 2];
            int[] voyage = [2, 1];
            TreeNode node = TreeNode.BuildTree(root);
            int[] exp = [-1];
            int[] res = alg.FlipMatchVoyage(node, voyage).ToArray();
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int?[] root = [1, 2, 3];
            int[] voyage = [1, 3, 2];
            TreeNode node = TreeNode.BuildTree(root);
            int[] exp = [1];
            int[] res = alg.FlipMatchVoyage(node, voyage).ToArray();
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int?[] root = [1, 2, 3];
            int[] voyage = [1, 2, 3];
            TreeNode node = TreeNode.BuildTree(root);
            int[] exp = [];
            int[] res = alg.FlipMatchVoyage(node, voyage).ToArray();
            Assert.Equal(exp, res);
        }
    }
}
