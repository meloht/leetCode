﻿using leetCode;
using leetCode._0101_0150;
using leetCode.Model.ThreeTreeNode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _116_PopulatingNextRightPointersInEachNodeUnitTest
    {
        _116_PopulatingNextRightPointersInEachNodeAlg alg = new _116_PopulatingNextRightPointersInEachNodeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2, 3, 4, 5, 6, 7];

            int?[] exp = [1, null, 2, 3, null, 4, 5, 6, 7, null];

            Node node = Node.BuildNodeTree(root);
           
            var nodeNew = alg.Connect(node);

            var res = Node.GetNodeList(nodeNew);
            bool bl = exp.SequenceEqual(res);

            Assert.IsTrue(bl);
        }
        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [];

            int?[] exp = [];

            Node node = Node.BuildNodeTree(root);

            var nodeNew = alg.Connect(node);

            var res = Node.GetNodeList(nodeNew);
            bool bl = exp.SequenceEqual(res);

            Assert.IsTrue(bl);
        }
    }
}
