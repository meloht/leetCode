using leetCode._0951_1000;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0998_MaximumBinaryTreeIITest
    {
        _0998_MaximumBinaryTreeIIAlg alg = new _0998_MaximumBinaryTreeIIAlg();

        [Fact]
        public void Test01()
        {
            int?[] root = [4, 1, 3, null, null, 2];
            int val = 5;
            int?[] exp = [5, 4, null, 1, 3, null, null, 2];
            var ress = alg.InsertIntoMaxTree(TreeNode.BuildTree(root), val);
            int?[] res = TreeNode.GetTreeLevelList(ress);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int?[] root = [5, 2, 4, null, 1];
            int val = 3;
            int?[] exp = [5, 2, 4, null, 1, null, 3];
            var ress = alg.InsertIntoMaxTree(TreeNode.BuildTree(root), val);
            int?[] res = TreeNode.GetTreeLevelList(ress);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int?[] root = [5, 2, 3, null, 1];
            int val = 4;
            int?[] exp = [5, 2, 4, null, 1, 3];
            var ress = alg.InsertIntoMaxTree(TreeNode.BuildTree(root), val);
            int?[] res = TreeNode.GetTreeLevelList(ress);
            Assert.Equal(exp, res);
        }
    }
}
