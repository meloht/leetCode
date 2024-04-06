using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0701_0750._703_KthLargestElementInAStreamAlg;

namespace Test._0701_0750
{
    [TestClass]
    public class _703_KthLargestElementInAStreamUnitTest
    {
       

        [TestMethod]
        public void TestCase01()
        {
            KthLargest kthLargest = new KthLargest(3, [4, 5, 8, 2]);
            Assert.AreEqual(4, kthLargest.Add(3));   // return 4
            Assert.AreEqual(5, kthLargest.Add(5));   // return 5
            Assert.AreEqual(5, kthLargest.Add(10));  // return 5
            Assert.AreEqual(8, kthLargest.Add(9));   // return 8
            Assert.AreEqual(8, kthLargest.Add(4));   // return 8
        }
    }
}
