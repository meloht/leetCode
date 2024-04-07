using leetCode._0401_0450;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _449_SerializeAndDeserializeBstUnitTest
    {
        _449_SerializeAndDeserializeBstAlg alg = new _449_SerializeAndDeserializeBstAlg();

        [TestMethod]
        public void TestCase01()
        {
            string exp = "2,1,3";
            var tree = alg.deserialize(exp);
            var res = alg.serialize(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string exp = "";
            var tree = alg.deserialize(exp);
            var res = alg.serialize(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
