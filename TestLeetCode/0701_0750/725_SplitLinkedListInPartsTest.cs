using leetCode;
using leetCode._0701_0750;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _725_SplitLinkedListInPartsTest
    {
        _725_SplitLinkedListInPartsAlg alg = new _725_SplitLinkedListInPartsAlg();

        private int[][] GetList(ListNode[] nodes)
        {
            int[][] res = new int[nodes.Length][];
            for (int i = 0; i < nodes.Length; i++)
            {
                res[i] = ListNode.GetLinkNodeList(nodes[i]);
            }
            return res;

        }
        [TestMethod]
        public void TestCase01()
        {
            int[] head = [1, 2, 3];
            int k = 5;
            int[][] exp = [[1], [2], [3], [], []];
            ListNode node = ListNode.BuildListNode(head);
            var resNode = alg.SplitListToParts(node, k);
            int[][] res = GetList(resNode);

            Assert.IsTrue(Utils.IsSameList(exp, res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int k = 3;
            int[][] exp = [[1, 2, 3, 4], [5, 6, 7], [8, 9, 10]];
            ListNode node = ListNode.BuildListNode(head);
            var resNode = alg.SplitListToParts(node, k);
            int[][] res = GetList(resNode);

            Assert.IsTrue(Utils.IsSameList(exp, res));
        }
    }
}
