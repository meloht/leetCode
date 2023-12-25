using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _143_ReorderLlistUnitTest
    {
        _143_ReorderLlistAlg alg = new _143_ReorderLlistAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [1, 2, 3, 4];
            int[] exp = [1, 4, 2, 3];
            var node = Utils.BuildListNode(head);
            var res = Utils.GetLinkNodeList(node);

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [1, 2, 3, 4, 5];
            int[] exp = [1, 5, 2, 4, 3];
            var node = Utils.BuildListNode(head);
            var res = Utils.GetLinkNodeList(node);

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
