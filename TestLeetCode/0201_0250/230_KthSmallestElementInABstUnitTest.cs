using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _230_KthSmallestElementInABstUnitTest
    {
        _230_KthSmallestElementInABstAlg alg = new _230_KthSmallestElementInABstAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [3, 1, 4, null, 2];
            int k = 1;
            var tree = Utils.BuildTree(root);
            int res = alg.KthSmallest(tree, k);
            int exp = 1;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [5, 3, 6, 2, 4, null, null, 1];
            int k = 3;
            var tree = Utils.BuildTree(root);
            int res = alg.KthSmallest(tree, k);
            int exp = 3;
            Assert.AreEqual(exp, res);
        }
    }
}
