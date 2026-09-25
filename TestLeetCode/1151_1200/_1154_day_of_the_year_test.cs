using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1151_1200
{
    [TestClass]
    public class _1154_day_of_the_year_test
    {
        _1154_day_of_the_year alg = new _1154_day_of_the_year();

        [TestMethod]
        public void TestCase01()
        {
            string date = "2019-01-09";
            int exp = 9;
            int res = alg.DayOfYear(date);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string date = "2019-02-10";
            int exp = 41;
            int res = alg.DayOfYear(date);
            Assert.AreEqual(exp, res);
        }

    }
}
