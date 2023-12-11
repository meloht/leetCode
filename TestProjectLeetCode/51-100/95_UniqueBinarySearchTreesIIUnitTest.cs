using leetCode;
using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _95_UniqueBinarySearchTreesIIUnitTest
    {
        _95_UniqueBinarySearchTreesIIAlg alg = new _95_UniqueBinarySearchTreesIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            IList<TreeNode> res = alg.GenerateTrees(3);

            var resArr = Utils.GetTreeList(res);
            int?[][] exp = { [1, null, 2, null, 3], [1, null, 3, 2], [2, 1, 3], [3, 1, null, null, 2], [3, 2, null, 1] };
            bool bl = Utils.IsSameList(exp, resArr);
            Assert.IsTrue(bl);
        }
        [TestMethod]
        public void TestCase02()
        {
            IList<TreeNode> res = alg.GenerateTrees(1);

            var resArr = Utils.GetTreeList(res);
            int?[][] exp = { [1] };
            bool bl = Utils.IsSameList(exp, resArr);
            Assert.IsTrue(bl);
        }
    }
}
