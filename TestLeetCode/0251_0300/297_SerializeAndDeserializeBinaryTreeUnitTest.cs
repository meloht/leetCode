using leetCode._0251_0300;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _297_SerializeAndDeserializeBinaryTreeUnitTest
    {
        _297_SerializeAndDeserializeBinaryTreeAlg.Codec alg = new _297_SerializeAndDeserializeBinaryTreeAlg.Codec();

        [TestMethod]
        public void TestCase01()
        {
            string root = "[1,2,3,null,null,4,5]";
            var tree = alg.deserialize(root);
            var res = alg.serialize(tree);

            Assert.AreEqual(root, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string root = "[]";
            var tree = alg.deserialize(root);
            var res = alg.serialize(tree);

            Assert.AreEqual(root, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            string root = "[1]";
            var tree = alg.deserialize(root);
            var res = alg.serialize(tree);

            Assert.AreEqual(root, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            string root = "[1,2]";
            var tree = alg.deserialize(root);
            var res = alg.serialize(tree);

            Assert.AreEqual(root, res);
        }
    }
}
