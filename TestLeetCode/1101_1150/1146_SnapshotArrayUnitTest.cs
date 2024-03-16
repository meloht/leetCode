using leetCode._1101_1150;
using System;
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
    }
}
