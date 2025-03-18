using leetCode;
using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _817_LinkedListComponentsTest
    {
        _817_LinkedListComponentsAlg alg = new _817_LinkedListComponentsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [0, 1, 2, 3], nums = [0, 1, 3];
            int exp = 2;
            ListNode node = ListNode.BuildListNode(head);
            int res = alg.NumComponents(node, nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [0, 1, 2, 3, 4], nums = [0, 3, 1, 4];
            int exp = 2;
            ListNode node = ListNode.BuildListNode(head);
            int res = alg.NumComponents(node, nums);
            Assert.AreEqual(exp, res);
        }
    }
}
