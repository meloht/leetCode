using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0151_0200._155_MinStackAlg;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _155_MinStackUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            _155_MinStackAlg.MinStack alg = new MinStack();
            alg.Push(-2);
            alg.Push(0);
            alg.Push(-3);
            Assert.AreEqual(-3, alg.GetMin());
            alg.Pop();
            Assert.AreEqual(0, alg.Top());
            Assert.AreEqual(-2, alg.GetMin());
        }
    }
}
