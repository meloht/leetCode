using leetCode;
using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _117_PopulatingNextRightPointersInEachNodeIIUnitTest
    {
        _117_PopulatingNextRightPointersInEachNodeIIAlg alg = new _117_PopulatingNextRightPointersInEachNodeIIAlg();
        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2, 3, 4, 5, null, 7];

            int?[] exp = [1, null, 2, 3, null, 4, 5, 7, null];

            NodeThree node = Utils.BuildNodeTree(root);

            var nodeNew = alg.Connect(node);

            var res = Utils.GetNodeList(nodeNew);
            bool bl = exp.SequenceEqual(res);

            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [];

            int?[] exp = [];

            NodeThree node = Utils.BuildNodeTree(root);

            var nodeNew = alg.Connect(node);

            var res = Utils.GetNodeList(nodeNew);
            bool bl = exp.SequenceEqual(res);

            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [1, 2, 3, 4, null, null, 5];

            int?[] exp = [1, null, 2, 3, null, 4, 5, null];

            NodeThree node = Utils.BuildNodeTree(root);

            var nodeNew = alg.Connect(node);

            var res = Utils.GetNodeList(nodeNew);
            bool bl = exp.SequenceEqual(res);

            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase04()
        {
            int?[] root = [3, 9, 20, null, null, 15, 7];

            int?[] exp = [3, null, 9, 20, null, 15, 7, null];

            NodeThree node = Utils.BuildNodeTree(root);

            var nodeNew = alg.Connect(node);

            var res = Utils.GetNodeList(nodeNew);
            bool bl = exp.SequenceEqual(res);

            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase05()
        {
            int?[] root = [1, 2, 3, 4, 5, null, 6, 7, null, null, null, null, 8];

            int?[] exp = [1, null, 2, 3, null, 4, 5, 6, null, 7, 8, null];

            NodeThree node = Utils.BuildNodeTree(root);

            var nodeNew = alg.Connect(node);

            var res = Utils.GetNodeList(nodeNew);
            bool bl = exp.SequenceEqual(res);

            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase06()
        {
            int?[] root = [1, 2, 3, 4, 5, null, 6, 7];

            int?[] exp = [1, null, 2, 3, null, 4, 5, 6, null, 7, null];

            NodeThree node = Utils.BuildNodeTree(root);

            var nodeNew = alg.Connect(node);

            var res = Utils.GetNodeList(nodeNew);
            bool bl = exp.SequenceEqual(res);

            Assert.IsTrue(bl);
        }
    }
}
