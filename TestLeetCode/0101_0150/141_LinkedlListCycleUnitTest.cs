using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _141_LinkedlListCycleUnitTest
    {
        _141_LinkedlListCycleAlg alg = new _141_LinkedlListCycleAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [3, 2, 0, -4];
            int pos = 1;
            var node = Utils.BuildListNode(head, pos);
            bool bl = alg.HasCycle(node);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [1, 2];
            int pos = 0;
            var node = Utils.BuildListNode(head, pos);
            bool bl = alg.HasCycle(node);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] head = [1];
            int pos = -1;
            var node = Utils.BuildListNode(head, pos);
            bool bl = alg.HasCycle(node);
            Assert.AreEqual(false, bl);
        }


    }
}
