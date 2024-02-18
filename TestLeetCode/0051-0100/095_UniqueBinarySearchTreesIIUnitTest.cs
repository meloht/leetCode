using leetCode;
using leetCode._51_100;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0051_0100
{
    [TestClass]
    public class _95_UniqueBinarySearchTreesIIUnitTest
    {
        _95_UniqueBinarySearchTreesIIAlg alg = new _95_UniqueBinarySearchTreesIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            IList<TreeNode> res = alg.GenerateTrees(3);

            var resArr = TreeNode.GetTreeList(res);
            int?[][] exp = { [1, null, 2, null, 3], [1, null, 3, 2], [2, 1, 3], [3, 1, null, null, 2], [3, 2, null, 1] };
            bool bl = Utils.IsSameList(exp, resArr);
            Assert.IsTrue(bl);
        }
        [TestMethod]
        public void TestCase02()
        {
            IList<TreeNode> res = alg.GenerateTrees(1);

            var resArr = TreeNode.GetTreeList(res);
            int?[][] exp = { [1] };
            bool bl = Utils.IsSameList(exp, resArr);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            IList<TreeNode> res = alg.GenerateTrees(4);

            var resArr = TreeNode.GetTreeList(res);
            int?[][] exp = { [1, null, 2, null, 3, null, 4], [1, null, 2, null, 4, 3], [1, null, 3, 2, 4], [1, null, 4, 2, null, null, 3], [1, null, 4, 3, null, 2], [2, 1, 3, null, null, null, 4], [2, 1, 4, null, null, 3], [3, 1, 4, null, 2], [3, 2, 4, 1], [4, 1, null, null, 2, null, 3], [4, 1, null, null, 3, 2], [4, 2, null, 1, 3], [4, 3, null, 1, null, null, 2], [4, 3, null, 2, null, 1] };
            bool bl = Utils.IsSameList(exp, resArr);
            Assert.IsTrue(bl);
        }
    }
}
