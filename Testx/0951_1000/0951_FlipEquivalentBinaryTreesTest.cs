using leetCode._0951_1000;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0951_FlipEquivalentBinaryTreesTest
    {
        _0951_FlipEquivalentBinaryTreesAlg alg = new _0951_FlipEquivalentBinaryTreesAlg();
        
        [Fact]
        public void Test01()
        {
            int?[] root1 = [1, 2, 3, 4, 5, 6, null, null, null, 7, 8], root2 = [1, 3, 2, null, 6, 4, 5, null, null, null, null, 8, 7];
            bool exp = true;
            TreeNode root11 = TreeNode.BuildTree(root1);
            TreeNode root12 = TreeNode.BuildTree(root2);
            bool res = alg.FlipEquiv(root11, root12);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int?[] root1 = [], root2 = [];
            bool exp = true;
            TreeNode root11 = TreeNode.BuildTree(root1);
            TreeNode root12 = TreeNode.BuildTree(root2);
            bool res = alg.FlipEquiv(root11, root12);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int?[] root1 = [], root2 = [1];
            bool exp = false;
            TreeNode root11 = TreeNode.BuildTree(root1);
            TreeNode root12 = TreeNode.BuildTree(root2);
            bool res = alg.FlipEquiv(root11, root12);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int?[] root1 = [6, 1, 0], root2 = [6, null, 1];
            bool exp = false;
            TreeNode root11 = TreeNode.BuildTree(root1);
            TreeNode root12 = TreeNode.BuildTree(root2);
            bool res = alg.FlipEquiv(root11, root12);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test05()
        {
            int?[] root1 = [1], root2 = [1, 2];
            bool exp = false;
            TreeNode root11 = TreeNode.BuildTree(root1);
            TreeNode root12 = TreeNode.BuildTree(root2);
            bool res = alg.FlipEquiv(root11, root12);
            Assert.Equal(exp, res);
        }
    }
}
