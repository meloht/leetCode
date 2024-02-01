using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _235_LowestCommonAncestorOfABinarySearchTreeUnitTest
    {
        _235_LowestCommonAncestorOfABinarySearchTreeAlg alg = new _235_LowestCommonAncestorOfABinarySearchTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [6, 2, 8, 0, 4, 7, 9, null, null, 3, 5];
            var tree = Utils.BuildTree(root);
            var p = Utils.GetTreeNodeByVal(2, tree);
            var q = Utils.GetTreeNodeByVal(8, tree);
            int exp = 6;
            var res = alg.LowestCommonAncestor(tree, p, q);
            Assert.AreEqual(exp, res.val);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [6, 2, 8, 0, 4, 7, 9, null, null, 3, 5];
            var tree = Utils.BuildTree(root);
            var p = Utils.GetTreeNodeByVal(2, tree);
            var q = Utils.GetTreeNodeByVal(4, tree);
            int exp = 2;
            var res = alg.LowestCommonAncestor(tree, p, q);
            Assert.AreEqual(exp, res.val);
        }
    }
}
