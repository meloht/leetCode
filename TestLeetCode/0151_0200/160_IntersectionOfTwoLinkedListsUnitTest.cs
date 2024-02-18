using leetCode;
using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;

namespace Test._0151_0200
{
    [TestClass]
    public class _160_IntersectionOfTwoLinkedListsUnitTest
    {

        _160_IntersectionOfTwoLinkedListsAlg alg = new _160_IntersectionOfTwoLinkedListsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] a = [4, 1, 8, 4, 5];
            int[] b = [5, 6, 1];

            var lista = ListNode.BuildListNode(a);
            int intersectVal = 8;
            ListNode intersectNode = null;
            ListNode node = lista;
            while (node != null)
            {
                if (node.val == intersectVal)
                {
                    intersectNode = node;
                    break;
                }
                node = node.next;
            }

            var listb = ListNode.BuildListNode(b);
            node = listb;
            ListNode last = null;
            while (node != null)
            {
                if (node.next == null)
                {
                    last = node;
                    break;
                }
                node = node.next;
            }
            last.next = intersectNode;

            var res = alg.GetIntersectionNode(lista, listb);
            Assert.AreEqual(res.val, intersectVal);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] a = [1, 9, 1, 2, 4];
            int[] b = [3];

            var lista = ListNode.BuildListNode(a);
            int intersectVal = 2;
            ListNode intersectNode = null;
            ListNode node = lista;
            while (node != null)
            {
                if (node.val == intersectVal)
                {
                    intersectNode = node;
                    break;
                }
                node = node.next;
            }

            var listb = ListNode.BuildListNode(b);
            node = listb;
            ListNode last = null;
            while (node != null)
            {
                if (node.next == null)
                {
                    last = node;
                    break;
                }
                node = node.next;
            }
            last.next = intersectNode;

            var res = alg.GetIntersectionNode(lista, listb);
            Assert.AreEqual(res.val, intersectVal);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] a = [2, 6, 4];
            int[] b = [1, 5];

            var lista = ListNode.BuildListNode(a);
           
            var listb = ListNode.BuildListNode(b);

            var res = alg.GetIntersectionNode(lista, listb);
            Assert.AreEqual(res, null);
        }
    }
}
