using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _129_SumRootToLeafNumbersUnitTest
    {
        _129_SumRootToLeafNumbersAlg alg = new _129_SumRootToLeafNumbersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2, 3];
            var tree=Utils.BuildTree(root);
            int res=alg.SumNumbers(tree);
            Assert.AreEqual(25, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [4, 9, 0, 5, 1];
            var tree = Utils.BuildTree(root);
            int res = alg.SumNumbers(tree);
            Assert.AreEqual(1026, res);
        }
    }
}
