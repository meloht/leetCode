using leetCode._0851_0900;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _863_AllNodesDistanceKInBinaryTreeTest
    {
        _863_AllNodesDistanceKInBinaryTreeAlg alg = new _863_AllNodesDistanceKInBinaryTreeAlg();
        [Fact]
        public void Test01()
        {
            int?[] root = [3, 5, 1, 6, 2, 0, 8, null, null, 7, 4];
            int target = 5, k = 2;
            int[] exp = [7, 4, 1];
            TreeNode node = TreeNode.BuildTree(root);
            TreeNode targetNode = new TreeNode(target);
            int[] res = alg.DistanceK(node, targetNode, k).ToArray();
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int?[] root = [1];
            int target = 1, k = 3;
            int[] exp = [];
            TreeNode node = TreeNode.BuildTree(root);
            TreeNode targetNode = new TreeNode(target);
            int[] res = alg.DistanceK(node, targetNode, k).ToArray();
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int?[] root = [0, 1, null, 3, 2];
            int target = 2, k = 1;
            int[] exp = [1];
            TreeNode node = TreeNode.BuildTree(root);
            TreeNode targetNode = new TreeNode(target);
            int[] res = alg.DistanceK(node, targetNode, k).ToArray();
            Assert.Equal(exp, res);
        }
    }
}
