using leetCode._0651_0700;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _654_MaximumBinaryTreeTest
    {
        _654_MaximumBinaryTreeAlg alg = new _654_MaximumBinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 2, 1, 6, 0, 5];
            int?[] exp = [6, 3, 5, null, 2, 0, null, null, 1];
            var tree = alg.ConstructMaximumBinaryTree(nums);
            int?[] res = TreeNode.GetTreeLevelList(tree);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [3, 2, 1];
            int?[] exp = [3, null, 2, null, 1];
            var tree = alg.ConstructMaximumBinaryTree(nums);
            int?[] res = TreeNode.GetTreeLevelList(tree);
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
