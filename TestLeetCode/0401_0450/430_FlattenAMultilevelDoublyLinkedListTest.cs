using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.ListNodes;

namespace Test._0401_0450
{
    [TestClass]
    public class _430_FlattenAMultilevelDoublyLinkedListTest
    {
        _430_FlattenAMultilevelDoublyLinkedListAlg alg = new _430_FlattenAMultilevelDoublyLinkedListAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] head = [1, 2, 3, 4, 5, 6, null, null, null, 7, 8, 9, 10, null, null, 11, 12];
            int[] exp = [1, 2, 3, 7, 8, 11, 12, 9, 10, 4, 5, 6];
            var node = Node.Build(head);
            var res = alg.Flatten(node);
            int[] arr = Node.GetList(res).ToArray();
            Assert.IsTrue(arr.SequenceEqual(exp));

        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] head = [1, 2, null, 3];
            int[] exp = [1, 3, 2];
            var node = Node.Build(head);
            var res = alg.Flatten(node);
            int[] arr = Node.GetList(res).ToArray();
            Assert.IsTrue(arr.SequenceEqual(exp));

        }
    }
}
