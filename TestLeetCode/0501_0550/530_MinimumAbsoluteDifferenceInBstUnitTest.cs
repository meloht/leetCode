using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _530_MinimumAbsoluteDifferenceInBstUnitTest
    {
        _530_MinimumAbsoluteDifferenceInBstAlg alg = new _530_MinimumAbsoluteDifferenceInBstAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [4, 2, 6, 1, 3];
            var tree = Utils.BuildTree(root);
            int exp = 1;
            int res = alg.GetMinimumDifference(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 0, 48, null, null, 12, 49];
            var tree = Utils.BuildTree(root);
            int exp = 1;
            int res = alg.GetMinimumDifference(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [236, 104, 701, null, 227, null, 911];
            var tree = Utils.BuildTree(root);
            int exp = 9;
            int res = alg.GetMinimumDifference(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
