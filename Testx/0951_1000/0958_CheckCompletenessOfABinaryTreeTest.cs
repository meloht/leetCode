using leetCode._0951_1000;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0958_CheckCompletenessOfABinaryTreeTest
    {
        _0958_CheckCompletenessOfABinaryTreeAlg alg = new _0958_CheckCompletenessOfABinaryTreeAlg();
        [Fact]
        public void Test01()
        {
            int?[] root = [1, 2, 3, 4, 5, 6];
            bool exp = true;
            TreeNode node = TreeNode.BuildTree(root);
            bool res = alg.IsCompleteTree(node);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int?[] root = [1, 2, 3, 4, 5, null, 7];
            bool exp = false;
            TreeNode node = TreeNode.BuildTree(root);
            bool res = alg.IsCompleteTree(node);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int?[] root = [1, 2, 3, 5];
            bool exp = true;
            TreeNode node = TreeNode.BuildTree(root);
            bool res = alg.IsCompleteTree(node);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int?[] root = [1, 2, 3, null, null, 7, 8];
            bool exp = false;
            TreeNode node = TreeNode.BuildTree(root);
            bool res = alg.IsCompleteTree(node);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test05()
        {
            int?[] root = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, null, null, 15];
            bool exp = false;
            TreeNode node = TreeNode.BuildTree(root);
            bool res = alg.IsCompleteTree(node);
            Assert.Equal(exp, res);
        }
    }
}
