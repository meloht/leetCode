using leetCode._101_150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _106_ConstructBinaryTreeFromInorderAndPostorderTraversalUnitTest
    {
        _106_ConstructBinaryTreeFromInorderAndPostorderTraversalAlg alg = new _106_ConstructBinaryTreeFromInorderAndPostorderTraversalAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[] inorder = [9, 3, 15, 20, 7];
            int[] postorder = [9, 15, 7, 20, 3];

            int?[] exp = [3, 9, 20, null, null, 15, 7];

            var tree = alg.BuildTree(inorder, postorder);

            var res = Utils.GetTreeList(tree);

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] inorder = [-1];
            int[] postorder = [-1];

            int?[] exp = [-1];

            var tree = alg.BuildTree(inorder, postorder);

            var res = Utils.GetTreeList(tree);

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
