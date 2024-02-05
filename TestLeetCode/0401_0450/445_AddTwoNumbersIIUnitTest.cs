using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _445_AddTwoNumbersIIUnitTest
    {
        _445_AddTwoNumbersIIAlg alg = new _445_AddTwoNumbersIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] l1 = [7, 2, 4, 3], l2 = [5, 6, 4];
            var ll1 = Utils.BuildListNode(l1);
            var ll2 = Utils.BuildListNode(l2);
            var res = alg.AddTwoNumbers(ll1, ll2);
            int[] exp = [7, 8, 0, 7];
            int[] resu = Utils.GetLinkNodeList(res);
            Assert.IsTrue(exp.SequenceEqual(resu));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] l1 = [2, 4, 3], l2 = [5, 6, 4];
            var ll1 = Utils.BuildListNode(l1);
            var ll2 = Utils.BuildListNode(l2);
            var res = alg.AddTwoNumbers(ll1, ll2);
            int[] exp = [8, 0, 7];
            int[] resu = Utils.GetLinkNodeList(res);
            Assert.IsTrue(exp.SequenceEqual(resu));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] l1 = [0], l2 = [0];
            var ll1 = Utils.BuildListNode(l1);
            var ll2 = Utils.BuildListNode(l2);
            var res = alg.AddTwoNumbers(ll1, ll2);
            int[] exp = [0];
            int[] resu = Utils.GetLinkNodeList(res);
            Assert.IsTrue(exp.SequenceEqual(resu));
        }
    }
}
