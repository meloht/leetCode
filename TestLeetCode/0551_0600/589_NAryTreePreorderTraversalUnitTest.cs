using leetCode._0551_0600;
using leetCode.Model.NTreeNode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _589_NAryTreePreorderTraversalUnitTest
    {
        _589_NAryTreePreorderTraversalAlg alg = new _589_NAryTreePreorderTraversalAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, null, 3, 2, 4, null, 5, 6];
            var tree = Node.Build(root);
            int[] exp = [1, 3, 5, 6, 2, 4];
            int[] res = alg.Preorder(tree).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13, null, null, 14];
            var tree = Node.Build(root);
            int[] exp = [1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10];
            int[] res = alg.Preorder(tree).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
