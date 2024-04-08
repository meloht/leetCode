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
    public class _559_MaximumDepthOfNAryTreeUnitTest
    {
        _559_MaximumDepthOfNAryTreeAlg alg = new _559_MaximumDepthOfNAryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, null, 3, 2, 4, null, 5, 6];
            var tree = Node.Build(root);
            int exp = 3;
            int res = alg.MaxDepth(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13, null, null, 14];
            var tree = Node.Build(root);
            int exp = 5;
            int res = alg.MaxDepth(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
