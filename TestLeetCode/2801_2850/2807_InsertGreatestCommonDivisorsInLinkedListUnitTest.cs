using leetCode._2801_2850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2801_2850
{
    [TestClass]
    public class _2807_InsertGreatestCommonDivisorsInLinkedListUnitTest
    {
        _2807_InsertGreatestCommonDivisorsInLinkedListAlg alg = new _2807_InsertGreatestCommonDivisorsInLinkedListAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [18, 6, 10, 3];
            var list = Utils.BuildListNode(head);
            var res = alg.InsertGreatestCommonDivisors(list);
            int[] resu = Utils.GetLinkNodeList(res);

            int[] exp = [18, 6, 6, 2, 10, 1, 3];

            bool bl = exp.SequenceEqual(resu);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [7];
            var list = Utils.BuildListNode(head);
            var res = alg.InsertGreatestCommonDivisors(list);
            int[] resu = Utils.GetLinkNodeList(res);

            int[] exp = [7];

            bool bl = exp.SequenceEqual(resu);
            Assert.IsTrue(bl);
        }
    }
}
