using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0201_0250._225_ImplementStackUsingQueuesAlg;

namespace Test._0201_0250
{
    [TestClass]
    public class _225_ImplementStackUsingQueuesUnitTest
    {

        [TestMethod]
        public void TestCase01()
        {
            _225_ImplementStackUsingQueuesAlg.MyStack stack = new _225_ImplementStackUsingQueuesAlg.MyStack();
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Top()); // 返回 2
            Assert.AreEqual(2, stack.Pop()); // 返回 2
            Assert.AreEqual(false, stack.Empty()); // 返回 False
        }
    }
}
