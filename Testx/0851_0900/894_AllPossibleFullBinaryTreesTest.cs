using leetCode._0851_0900;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _894_AllPossibleFullBinaryTreesTest
    {
        _894_AllPossibleFullBinaryTreesAlg alg = new _894_AllPossibleFullBinaryTreesAlg();
        [Fact]
        public void Test01()
        {
            int n = 7;
            int?[][] exp = [
                [0, 0, 0, null, null, 0, 0, null, null, 0, 0],
            [0, 0, 0, null, null, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, null, null, null, null, 0, 0],
            [0, 0, 0, 0, 0, null, null, 0, 0]];

            var res = alg.AllPossibleFBT(n);
            var ress = TreeNode.GetTreeLevelLists(res).ToArray();

            Assert.True(Utils.IsSameList(exp,ress));
        }

        [Fact]
        public void Test02()
        {
            int n = 3;
            int?[][] exp = [[0, 0, 0]];

            var res = alg.AllPossibleFBT(n);
            var ress = TreeNode.GetTreeLevelLists(res).ToArray();

            Assert.True(Utils.IsSameList(exp, ress));
        }
    }
}
