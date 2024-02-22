using leetCode._0851_0900;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{

    [TestClass]
    public class _889_ConstructBinaryTreeFromPreorderAndPostorderTraversalUnitTest
    {
        _889_ConstructBinaryTreeFromPreorderAndPostorderTraversalAlg alg = new _889_ConstructBinaryTreeFromPreorderAndPostorderTraversalAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] preorder = [1, 2, 4, 5, 3, 6, 7], postorder = [4, 5, 2, 6, 7, 3, 1];
            var tree = alg.ConstructFromPrePost(preorder, postorder);
            int[] exp = [1, 2, 4, 5, 3, 6, 7];
            int[] result = TreeNode.PreOrderList(tree);
            Assert.IsTrue(exp.SequenceEqual(result));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] preorder = [1], postorder = [1];
            var tree = alg.ConstructFromPrePost(preorder, postorder);
            int[] exp = [1];
            int[] result = TreeNode.PreOrderList(tree);
            Assert.IsTrue(exp.SequenceEqual(result));
        }
    }
}
