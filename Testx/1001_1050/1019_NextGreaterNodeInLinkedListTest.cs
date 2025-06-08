using leetCode;
using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1019_NextGreaterNodeInLinkedListTest
    {
        _1019_NextGreaterNodeInLinkedListAlg alg = new _1019_NextGreaterNodeInLinkedListAlg();

        [Fact]
        public void Test01()
        {
            int[] head = [2, 1, 5];
            int[] exp = [5, 5, 0];
            ListNode node = ListNode.BuildListNode(head);
            int[] res = alg.NextLargerNodes(node);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] head = [2, 7, 4, 3, 5];
            int[] exp = [7, 0, 5, 5, 0];
            ListNode node = ListNode.BuildListNode(head);
            int[] res = alg.NextLargerNodes(node);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] head = [2, 5, 4, 1, 3, 7];
            int[] exp = [5, 7, 7, 3, 7, 0];
            ListNode node = ListNode.BuildListNode(head);
            int[] res = alg.NextLargerNodes(node);
            Assert.Equal(exp, res);
        }
    }
}
