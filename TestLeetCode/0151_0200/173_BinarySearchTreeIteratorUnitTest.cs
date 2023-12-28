using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _173_BinarySearchTreeIteratorUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            int?[] arr = [7, 3, 15, null, null, 9, 20];
            var tree = Utils.BuildTree(arr);
            _173_BinarySearchTreeIteratorAlg.BSTIterator bSTIterator = new(tree);
            // 返回 3
            Assert.AreEqual(3, bSTIterator.Next());
            // 返回 7
            Assert.AreEqual(7, bSTIterator.Next());
            // 返回 True
            Assert.AreEqual(true, bSTIterator.HasNext());
            // 返回 9
            Assert.AreEqual(9, bSTIterator.Next());
            // 返回 True
            Assert.AreEqual(true, bSTIterator.HasNext());
            // 返回 15
            Assert.AreEqual(15, bSTIterator.Next());
            // 返回 True
            Assert.AreEqual(true, bSTIterator.HasNext());
            // 返回 20
            Assert.AreEqual(20, bSTIterator.Next());
            // 返回 False
            Assert.AreEqual(false, bSTIterator.HasNext());
        }
    }
}
