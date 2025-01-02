using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0701_0750._729_MyCalendarIAlg;

namespace Test._0701_0750
{
    [TestClass]
    public class _729_MyCalendarITest
    {
        [TestMethod]
        public void TestCase01()
        {
            MyCalendar myCalendar = new MyCalendar();
            Assert.IsTrue(myCalendar.Book(10, 20)); // return True
            Assert.IsFalse(myCalendar.Book(15, 25)); // return False ，这个日程安排不能添加到日历中，因为时间 15 已经被另一个日程安排预订了。
            Assert.IsTrue(myCalendar.Book(20, 30)); // return True ，这个日程安排可以添加到日历中，因为第一个日程安排预订的每个时间都小于 20 ，且不包含时间 20 。
        }
    }
}
