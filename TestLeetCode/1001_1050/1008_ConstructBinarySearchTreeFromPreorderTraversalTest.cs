using leetCode._1001_1050;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1008_ConstructBinarySearchTreeFromPreorderTraversalTest
    {
        _1008_ConstructBinarySearchTreeFromPreorderTraversalAlg alg = new _1008_ConstructBinarySearchTreeFromPreorderTraversalAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] preorder = [8, 5, 1, 7, 10, 12];
            int?[] exp = [8, 5, 10, 1, 7, null, 12];
            var res = alg.BstFromPreorder(preorder);
            int?[] ress = TreeNode.GetTreeLevelList(res);

            Assert.IsTrue(exp.SequenceEqual(ress));
        }

         [TestMethod]
        public void TestCase02()
        {
            int[] preorder = [1, 3];
            int?[] exp = [1, null, 3];
            var res = alg.BstFromPreorder(preorder);
            int?[] ress = TreeNode.GetTreeLevelList(res);

            Assert.IsTrue(exp.SequenceEqual(ress));
        }
    }
}
