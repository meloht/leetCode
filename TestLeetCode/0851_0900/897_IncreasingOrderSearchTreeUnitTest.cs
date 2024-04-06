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
    public class _897_IncreasingOrderSearchTreeUnitTest
    {
        _897_IncreasingOrderSearchTreeAlg alg = new _897_IncreasingOrderSearchTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [5, 3, 6, 2, 4, null, 8, 1, null, null, null, 7, 9];

            var tree = TreeNode.BuildTree(root);

            int?[] exp = [1, null, 2, null, 3, null, 4, null, 5, null, 6, null, 7, null, 8, null, 9];
            var resTree = alg.IncreasingBST(tree);
            int?[] res = TreeNode.GetTreeLevelList(resTree);

            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [5, 1, 7];

            var tree = TreeNode.BuildTree(root);

            int?[] exp = [1, null, 5, null, 7];
            var resTree = alg.IncreasingBST(tree);
            int?[] res = TreeNode.GetTreeLevelList(resTree);

            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
