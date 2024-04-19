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
    public class _872_LeafSimilarTreesUnitTest
    {
        _872_LeafSimilarTreesAlg alg = new _872_LeafSimilarTreesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root1 = [3, 5, 1, 6, 2, 9, 8, null, null, 7, 4],
                root2 = [3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 8];

            var tree1 = TreeNode.BuildTree(root1);
            var tree2 = TreeNode.BuildTree(root2);
            bool exp = true;
            bool res = alg.LeafSimilar(tree1, tree2);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int?[] root1 = [1, 2, 3], root2 = [1, 3, 2];

            var tree1 = TreeNode.BuildTree(root1);
            var tree2 = TreeNode.BuildTree(root2);
            bool exp = false;
            bool res = alg.LeafSimilar(tree1, tree2);
            Assert.AreEqual(exp, res);
        }
    }
}
