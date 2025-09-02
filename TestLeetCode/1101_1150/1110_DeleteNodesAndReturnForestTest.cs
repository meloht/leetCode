using leetCode._1101_1150;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1110_DeleteNodesAndReturnForestTest
    {
        _1110_DeleteNodesAndReturnForestAlg alg = new _1110_DeleteNodesAndReturnForestAlg();

        [TestMethod]
        public void Test01()
        {
            int?[] root = [1, 2, 3, 4, 5, 6, 7];
            int[] to_delete = [3, 5];
            int?[][] exp = [[1, 2, null, 4], [6], [7]];
            var tree = TreeNode.BuildTree(root);
            var res = alg.DelNodes(tree, to_delete);
            int?[][] ress = new int?[res.Count][];
            for (int i = 0; i < res.Count; i++)
            {
                ress[i] = TreeNode.GetTreeLevelList(res[i]);
               
            }
            Assert.IsTrue(Utils.IsSameArrNull(exp, ress));
        }

        [TestMethod]
        public void Test02()
        {
            int?[] root = [1, 2, 4, null, 3];
            int[] to_delete = [3];
            int?[][] exp = [[1, 2, 4]];
            var tree = TreeNode.BuildTree(root);
            var res = alg.DelNodes(tree, to_delete);
            int?[][] ress = new int?[res.Count][];
            for (int i = 0; i < res.Count; i++)
            {
                ress[i] = TreeNode.GetTreeLevelList(res[i]);
              
            }
            Assert.IsTrue(Utils.IsSameArrNull(exp, ress));

        }
    }
}
