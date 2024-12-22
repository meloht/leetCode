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
    public class _655_PrintBinaryTreeTest
    {
        _655_PrintBinaryTreeAlg alg = new _655_PrintBinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2];
            var tree = TreeNode.BuildTree(root);
            IList<IList<string>> exp = [["", "1", ""], ["2", "", ""]];
            IList<IList<string>> res = alg.PrintTree(tree);
            Assert.IsTrue(Utils.IsSameList(exp,res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 2, 3, null, 4];
            var tree = TreeNode.BuildTree(root);
            IList<IList<string>> exp = [["","","","1","","",""],
 ["","2","","","","3",""],
 ["","","4","","","",""]];
            IList<IList<string>> res = alg.PrintTree(tree);
            Assert.IsTrue(Utils.IsSameList(exp, res));
        }
    }
}
