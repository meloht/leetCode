using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _138_CopyListWithRandomPointerUnitTest
    {
        _138_CopyListWithRandomPointerAlg alg = new _138_CopyListWithRandomPointerAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[][] head = [[7, null], [13, 0], [11, 4], [10, 2], [1, 0]];
            var node = _138_CopyListWithRandomPointerAlg.Node.Build(head);
            var ls = _138_CopyListWithRandomPointerAlg.Node.GetList(node);
            int?[][] exp = [[7, null], [13, 0], [11, 4], [10, 2], [1, 0]];

            bool bl = Utils.IsSameList(exp, ls);
            Assert.IsTrue(bl);
        }


        [TestMethod]
        public void TestCase02()
        {
            int?[][] head = [[3, null], [3, 0], [3, null]];
            var node = _138_CopyListWithRandomPointerAlg.Node.Build(head);
            var ls = _138_CopyListWithRandomPointerAlg.Node.GetList(node);
            int?[][] exp = [[3, null], [3, 0], [3, null]];

            bool bl = Utils.IsSameList(exp, ls);
            Assert.IsTrue(bl);
        }
    }
}
