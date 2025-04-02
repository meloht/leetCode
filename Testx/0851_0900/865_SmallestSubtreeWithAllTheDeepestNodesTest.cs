using leetCode._0851_0900;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _865_SmallestSubtreeWithAllTheDeepestNodesTest
    {
        _865_SmallestSubtreeWithAllTheDeepestNodesAlg alg = new _865_SmallestSubtreeWithAllTheDeepestNodesAlg();

        [Fact]
        public void Test01()
        {
            int?[] root = [3, 5, 1, 6, 2, 0, 8, null, null, 7, 4];
            var node = TreeNode.BuildTree(root);
            int?[] exp = [2, 7, 4];
            var res = alg.SubtreeWithAllDeepest(node);
            int?[] ress = TreeNode.GetTreeLevelList(res);

            Assert.Equal(exp, ress);
        }

        [Fact]
        public void Test02()
        {
            int?[] root = [1];
            var node = TreeNode.BuildTree(root);
            int?[] exp = [1];
            var res = alg.SubtreeWithAllDeepest(node);
            int?[] ress = TreeNode.GetTreeLevelList(res);

            Assert.Equal(exp, ress);
        }

        [Fact]
        public void Test03()
        {
            int?[] root = [0, 1, 3, null, 2];
            var node = TreeNode.BuildTree(root);
            int?[] exp = [2];
            var res = alg.SubtreeWithAllDeepest(node);
            int?[] ress = TreeNode.GetTreeLevelList(res);

            Assert.Equal(exp, ress);
        }

        [Fact]
        public void Test04()
        {
            int?[] root = [0, 3, 1, 4, null, 2, null, null, 6, null, 5];
            var node = TreeNode.BuildTree(root);
            int?[] exp = [0, 3, 1, 4, null, 2, null, null, 6, null, 5];
            var res = alg.SubtreeWithAllDeepest(node);
            int?[] ress = TreeNode.GetTreeLevelList(res);

            Assert.Equal(exp, ress);
        }
    }
}
