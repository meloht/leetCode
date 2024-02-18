using leetCode._0401_0450;
using leetCode._2551_2600;
using leetCode.Model.NTreeNode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _429_NAryTreeLevelOrderTraversalUnitTest
    {
        _429_NAryTreeLevelOrderTraversalAlg alg = new _429_NAryTreeLevelOrderTraversalAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, null, 3, 2, 4, null, 5, 6];
            IList<IList<int>> exp = [[1], [3, 2, 4], [5, 6]];
            var node = Node.Build(root);

            var res = alg.LevelOrder(node);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13, null, null, 14];
            IList<IList<int>> exp = [[1], [2, 3, 4, 5], [6, 7, 8, 9, 10], [11, 12, 13], [14]];
            var node = Node.Build(root);

            var res = alg.LevelOrder(node);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

    }
}
