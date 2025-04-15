using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0901_0950._919_CompleteBinaryTreeInserterAlg;

namespace Testx._0901_0950
{
    public class _919_CompleteBinaryTreeInserterTest
    {
        [Fact]
        public void Test01()
        {
            CBTInserter cBTInserter = new CBTInserter(TreeNode.BuildTree([1, 2]));
            Assert.Equal(1, cBTInserter.Insert(3));  // 返回 1
            Assert.Equal(2, cBTInserter.Insert(4));  // 返回 2
            Assert.Equal([1, 2, 3, 4], TreeNode.GetTreeLevelList(cBTInserter.Get_root())); // 返回 [1, 2, 3, 4]

        }
    }
}
