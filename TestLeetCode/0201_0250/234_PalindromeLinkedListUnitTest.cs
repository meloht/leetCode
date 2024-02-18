using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;

namespace Test._0201_0250
{
    [TestClass]
    public class _234_PalindromeLinkedListUnitTest
    {
        _234_PalindromeLinkedListAlg alg = new _234_PalindromeLinkedListAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [1, 2, 2, 1];
            var node = ListNode.BuildListNode(head);
            bool exp = true;
            var res = alg.IsPalindrome(node);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [1, 2];
            var node = ListNode.BuildListNode(head);
            bool exp = false;
            var res = alg.IsPalindrome(node);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] head = [1, 2, 1];
            var node = ListNode.BuildListNode(head);
            bool exp = true;
            var res = alg.IsPalindrome(node);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] head = [1, 2, 2];
            var node = ListNode.BuildListNode(head);
            bool exp = false;
            var res = alg.IsPalindrome(node);
            Assert.AreEqual(exp, res);
        }
    }
}
