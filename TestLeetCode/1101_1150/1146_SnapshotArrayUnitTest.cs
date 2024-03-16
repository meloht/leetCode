using leetCode._1101_1150;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1146_SnapshotArrayUnitTest
    {

        [TestMethod]
        public void TestCase01()
        {
            _1146_SnapshotArrayAlg.SnapshotArray snapshotArr = new _1146_SnapshotArrayAlg.SnapshotArray(3);
            snapshotArr.Set(0, 5);  // 令 array[0] = 5
            Assert.AreEqual(snapshotArr.Snap(), 0);  // 获取快照，返回 snap_id = 0
            snapshotArr.Set(0, 6);
            Assert.AreEqual(snapshotArr.Get(0, 0), 5);  // 获取 snap_id = 0 的快照中 array[0] 的值，返回 5
        }

        [TestMethod]
        public void TestCase02()
        {
            _1146_SnapshotArrayAlg.SnapshotArray snapshotArr = new _1146_SnapshotArrayAlg.SnapshotArray(1);
            snapshotArr.Set(0, 4);
            snapshotArr.Set(0, 16);
            snapshotArr.Set(0, 13);
            Assert.AreEqual(snapshotArr.Snap(), 0);

            Assert.AreEqual(snapshotArr.Get(0, 0), 13);
            Assert.AreEqual(snapshotArr.Snap(), 1);
        }

        [TestMethod]
        public void TestCase03()
        {
            SortedList<int, int> list=new SortedList<int, int>();
            list.Add(1, 2);
            list.Add(2, 3);
            list.Add(3, 4);
            list.Add(4, 5);

           

            _1146_SnapshotArrayAlg.SnapshotArray snapshotArr = new _1146_SnapshotArrayAlg.SnapshotArray(1);
            Assert.AreEqual(snapshotArr.Snap(), 0);
            Assert.AreEqual(snapshotArr.Snap(), 1);
            snapshotArr.Set(0, 4);
            Assert.AreEqual(snapshotArr.Snap(), 2);
            Assert.AreEqual(snapshotArr.Get(0, 1), 0);
            snapshotArr.Set(0, 12);
            Assert.AreEqual(snapshotArr.Get(0, 1), 0);
            Assert.AreEqual(snapshotArr.Snap(), 3);
            Assert.AreEqual(snapshotArr.Get(0, 3), 12);
        }
    }
}
