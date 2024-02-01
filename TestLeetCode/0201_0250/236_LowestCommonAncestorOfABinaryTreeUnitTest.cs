using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _236_LowestCommonAncestorOfABinaryTreeUnitTest
    {
        _236_LowestCommonAncestorOfABinaryTreeAlg alg = new _236_LowestCommonAncestorOfABinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [3, 5, 1, 6, 2, 0, 8, null, null, 7, 4];
            var tree = Utils.BuildTree(root);
            var p = Utils.GetTreeNodeByVal(5, tree);
            var q = Utils.GetTreeNodeByVal(1, tree);
            int exp = 3;
            var res = alg.LowestCommonAncestor(tree, p, q);
            Assert.AreEqual(exp, res.val);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [3, 5, 1, 6, 2, 0, 8, null, null, 7, 4];
            var tree = Utils.BuildTree(root);
            var p = Utils.GetTreeNodeByVal(5, tree);
            var q = Utils.GetTreeNodeByVal(4, tree);
            int exp = 5;
            var res = alg.LowestCommonAncestor(tree, p, q);
            Assert.AreEqual(exp, res.val);
        }
    }
}
