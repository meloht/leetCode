using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0701_0750._732_MyCalendarIIIAlg;

namespace Test._0701_0750
{
    [TestClass]
    public class _732_MyCalendarIIITest
    {
        [TestMethod]
        public void TestCase01()
        {
            MyCalendarThree myCalendarThree = new MyCalendarThree();
            Assert.AreEqual(1, myCalendarThree.Book(10, 20)); // 返回 1 ，第一个日程安排可以预订并且不存在相交，所以最大 k 次预订是 1 次预订。
            Assert.AreEqual(1, myCalendarThree.Book(50, 60)); // 返回 1 ，第二个日程安排可以预订并且不存在相交，所以最大 k 次预订是 1 次预订。
            Assert.AreEqual(2, myCalendarThree.Book(10, 40)); // 返回 2 ，第三个日程安排 [10, 40) 与第一个日程安排相交，所以最大 k 次预订是 2 次预订。
            Assert.AreEqual(3, myCalendarThree.Book(5, 15)); // 返回 3 ，剩下的日程安排的最大 k 次预订是 3 次预订。
            Assert.AreEqual(3, myCalendarThree.Book(5, 10)); // 返回 3
            Assert.AreEqual(3, myCalendarThree.Book(25, 55)); // 返回 3
        }
    }
}
