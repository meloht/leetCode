using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0701_0750._731_MyCalendarIIAlg;

namespace Test._0701_0750
{
    [TestClass]
    public class _731_MyCalendarIITest
    {
        [TestMethod]
        public void TestCase01()
        {
            MyCalendarTwo myCalendarTwo = new MyCalendarTwo();
            Assert.AreEqual(true, myCalendarTwo.Book(10, 20)); // 返回 True，能够预定该日程。
            Assert.AreEqual(true, myCalendarTwo.Book(50, 60)); // 返回 True，能够预定该日程。
            Assert.AreEqual(true, myCalendarTwo.Book(10, 40)); // 返回 True，该日程能够被重复预定。
            Assert.AreEqual(false, myCalendarTwo.Book(5, 15));  // 返回 False，该日程导致了三重预定，所以不能预定。
            Assert.AreEqual(true, myCalendarTwo.Book(5, 10)); // 返回 True，能够预定该日程，因为它不使用已经双重预订的时间 10。
            Assert.AreEqual(true, myCalendarTwo.Book(25, 55)); // 返回 True，能够预定该日程，因为时间段 [25, 40) 将被第三个日程重复预定，时间段 [40, 50) 将被单独预定，而时间段 [50, 55) 将被第二个日程重复预定。
        }
    }
}
