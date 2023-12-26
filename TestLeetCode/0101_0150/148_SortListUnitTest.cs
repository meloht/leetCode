using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _148_SortListUnitTest
    {
        _148_SortListAlg alg = new _148_SortListAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [4, 2, 1, 3];
            var list = Utils.BuildListNode(head);
            var node = alg.SortList(list);
            int[] res = Utils.GetLinkNodeList(node);
            int[] exp = [1, 2, 3, 4];

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [-1, 5, 3, 4, 0];
            var list = Utils.BuildListNode(head);
            var node = alg.SortList(list);
            int[] res = Utils.GetLinkNodeList(node);
            int[] exp = [-1, 0, 3, 4, 5];

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
