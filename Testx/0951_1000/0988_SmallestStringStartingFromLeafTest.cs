using leetCode._0951_1000;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0988_SmallestStringStartingFromLeafTest
    {
        _0988_SmallestStringStartingFromLeafAlg alg = new _0988_SmallestStringStartingFromLeafAlg();

        [Fact]
        public void Test01()
        {
            int?[] root = [0, 1, 2, 3, 4, 3, 4];
            string exp = "dba";
            string res = alg.SmallestFromLeaf(TreeNode.BuildTree(root));
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int?[] root = [25, 1, 3, 1, 3, 0, 2];
            string exp = "adz";
            string res = alg.SmallestFromLeaf(TreeNode.BuildTree(root));
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int?[] root = [2, 2, 1, null, 1, 0, null, 0];
            string exp = "abc";
            string res = alg.SmallestFromLeaf(TreeNode.BuildTree(root));
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int?[] root = [18, 23, 17, 12, 2, 11, 15];
            string exp = "cxs";
            string res = alg.SmallestFromLeaf(TreeNode.BuildTree(root));
            Assert.Equal(exp, res);
        }
    }
}
