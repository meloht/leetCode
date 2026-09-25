using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1151_1200
{
    [TestClass]
    public class _1185_DayOfTheWeekTest
    {
        _1185_DayOfTheWeekAlg alg = new _1185_DayOfTheWeekAlg();

        [TestMethod]
        public void TestCase01()
        {
            int day = 31, month = 8, year = 2019;
            string exp = "Saturday";
            string res = alg.DayOfTheWeek(day, month, year);
            Assert.AreEqual(res, exp);
        }
        [TestMethod]
        public void TestCase02()
        {
            int day = 18, month = 7, year = 1999;
            string exp = "Sunday";
            string res = alg.DayOfTheWeek(day, month, year);
            Assert.AreEqual(res, exp);
        }

        [TestMethod]
        public void TestCase03()
        {
            int day = 15, month = 8, year = 1993;
            string exp = "Sunday";
            string res = alg.DayOfTheWeek(day, month, year);
            Assert.AreEqual(res, exp);
        }
    }
}
