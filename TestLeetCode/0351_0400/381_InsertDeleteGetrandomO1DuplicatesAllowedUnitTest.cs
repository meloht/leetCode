using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0351_0400._381_InsertDeleteGetrandomO1DuplicatesAllowedAlg;

namespace Test._0351_0400
{
    [TestClass]
    public class _381_InsertDeleteGetrandomO1DuplicatesAllowedUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            RandomizedCollection collection = new RandomizedCollection();// 初始化一个空的集合。
            Assert.IsTrue(collection.Insert(1));   // 返回 true，因为集合不包含 1。
                                                   // 将 1 插入到集合中。
            Assert.IsFalse(collection.Insert(1));   // 返回 false，因为集合包含 1。
                                                    // 将另一个 1 插入到集合中。集合现在包含 [1,1]。
            Assert.IsTrue(collection.Insert(2));   // 返回 true，因为集合不包含 2。
                                                   // 将 2 插入到集合中。集合现在包含 [1,1,2]。
            collection.GetRandom(); // getRandom 应当:
                                    // 有 2/3 的概率返回 1,
                                    // 1/3 的概率返回 2。
            Assert.IsTrue(collection.Remove(1));   // 返回 true，因为集合包含 1。
                                                   // 从集合中移除 1。集合现在包含 [1,2]。
            collection.GetRandom(); // getRandom 应该返回 1 或 2，两者的可能性相同。
        }

        [TestMethod]
        public void TestCase02()
        {
            RandomizedCollection collection = new RandomizedCollection();
            Assert.IsTrue(collection.Insert(1));   
                                                   
            Assert.IsTrue(collection.Remove(1));   
                                                   
            Assert.IsTrue(collection.Insert(1));   
        }

        [TestMethod]
        public void TestCase03()
        {
            RandomizedCollection collection = new RandomizedCollection();
            Assert.IsTrue(collection.Insert(0));

            Assert.IsTrue(collection.Insert(1));
            Assert.IsTrue(collection.Remove(0));

            Assert.IsTrue(collection.Insert(2));
            Assert.IsTrue(collection.Remove(1));
            Assert.AreEqual(2,collection.GetRandom());


        }

        [TestMethod]
        public void TestCase04()
        {
            RandomizedCollection collection = new RandomizedCollection();
            collection.Insert(1);
            collection.Insert(1);
            collection.Insert(2);
            collection.Insert(2);
            collection.Insert(2);

            collection.Remove(1);
            collection.Remove(1);
            collection.Remove(2);
            collection.Insert(1);
            collection.Remove(2);

            collection.GetRandom();


        }

      
    }
}
