using leetCode._101_150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _101_SymmetricTreeUnitTest
    {
        _101_SymmetricTreeAlg alg = new _101_SymmetricTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = { 1, 2, 2, 3, 4, 4, 3 };
            var tree = Utils.BuildTree(root);
            bool bl = alg.IsSymmetric(tree);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = { 1, 2, 2, null, 3, null, 3 };
            var tree = Utils.BuildTree(root);
            bool bl = alg.IsSymmetric(tree);
            Assert.AreEqual(false, bl);
        }
    }
}
