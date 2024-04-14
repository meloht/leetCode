using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0701_0750._705_DesignHashsetAlg;

namespace Test._0701_0750
{
    [TestClass]
    public class _705_DesignHashsetUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            MyHashSet myHashSet = new MyHashSet();
            myHashSet.Add(1);      // set = [1]
            myHashSet.Add(2);      // set = [1, 2]
            Assert.AreEqual(true, myHashSet.Contains(1)); // 返回 True
            Assert.AreEqual(false, myHashSet.Contains(3)); // 返回 False ，（未找到）
            myHashSet.Add(2);      // set = [1, 2]
            Assert.AreEqual(true, myHashSet.Contains(2)); // 返回 True
            myHashSet.Remove(2);   // set = [1]
            Assert.AreEqual(false, myHashSet.Contains(2)); // 返回 False ，（已移除）
        }
    }
}
