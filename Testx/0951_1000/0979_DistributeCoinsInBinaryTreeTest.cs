using leetCode._0951_1000;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0979_DistributeCoinsInBinaryTreeTest
    {
        _0979_DistributeCoinsInBinaryTreeAlg alg = new _0979_DistributeCoinsInBinaryTreeAlg();

        [Fact]
        public void Test01()
        {
            int?[] root = [3, 0, 0];
            int exp = 2;
            int res = alg.DistributeCoins(TreeNode.BuildTree(root));
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int?[] root = [0, 3, 0];
            int exp = 3;
            int res = alg.DistributeCoins(TreeNode.BuildTree(root));
            Assert.Equal(exp, res);
        }
    }
}
