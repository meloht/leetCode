using leetCode._2301_2350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2301_2350
{
    [TestClass]
    public class _2349_DesignANumberContainerSystemTest
    {
        [TestMethod]
        public void Test01()
        {
            _2349_DesignANumberContainerSystemAlg.NumberContainers nc = new _2349_DesignANumberContainerSystemAlg.NumberContainers();

            Assert.AreEqual(-1, nc.Find(10)); // 没有数字 10 ，所以返回 -1 。
            nc.Change(2, 10); // 容器中下标为 2 处填入数字 10 。
            nc.Change(1, 10); // 容器中下标为 1 处填入数字 10 。
            nc.Change(3, 10); // 容器中下标为 3 处填入数字 10 。
            nc.Change(5, 10); // 容器中下标为 5 处填入数字 10 。
            Assert.AreEqual(1, nc.Find(10)); // 数字 10 所在的下标为 1 ，2 ，3 和 5 。因为最小下标为 1 ，所以返回 1 。
            nc.Change(1, 20); // 容器中下标为 1 处填入数字 20 。注意，下标 1 处之前为 10 ，现在被替换为 20 。
            Assert.AreEqual(2, nc.Find(10)); // 数字 10 所在下标为 2 ，3 和 5 。最小下标为 2 ，所以返回 2 。

        }

        [TestMethod]
        public void Test02()
        {
            _2349_DesignANumberContainerSystemAlg.NumberContainers nc = new _2349_DesignANumberContainerSystemAlg.NumberContainers();

            Assert.AreEqual(-1, nc.Find(10)); 
            nc.Change(1, 10);
            Assert.AreEqual(1, nc.Find(10));
            nc.Change(1, 20);
            Assert.AreEqual(-1, nc.Find(10));
          
            Assert.AreEqual(1, nc.Find(20));
            Assert.AreEqual(-1, nc.Find(30));

        }
    }
}
