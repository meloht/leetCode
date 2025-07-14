using leetCode;
using leetCode._1251_1300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1251_1300
{
    [TestClass]
    public class _1290_ConvertBinaryNumberInALinkedListToIntegerTest
    {
        _1290_ConvertBinaryNumberInALinkedListToIntegerAlg alg = new _1290_ConvertBinaryNumberInALinkedListToIntegerAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [1, 0, 1];
            var node = ListNode.BuildListNode(head);
            int exp = 5;
            int res = alg.GetDecimalValue(node);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [0];
            var node = ListNode.BuildListNode(head);
            int exp = 0;
            int res = alg.GetDecimalValue(node);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] head = [1];
            var node = ListNode.BuildListNode(head);
            int exp = 1;
            int res = alg.GetDecimalValue(node);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] head = [1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0];
            var node = ListNode.BuildListNode(head);
            int exp = 18880;
            int res = alg.GetDecimalValue(node);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] head = [0, 0];
            var node = ListNode.BuildListNode(head);
            int exp = 0;
            int res = alg.GetDecimalValue(node);
            Assert.AreEqual(exp, res);
        }
    }
}
