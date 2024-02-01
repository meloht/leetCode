using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0151_0200
{
    [TestClass]
    public class _171_ExcelSheetColumnNumberUnitTest
    {
        _171_ExcelSheetColumnNumberAlg alg = new _171_ExcelSheetColumnNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            var columnNumber = "A";
            var res = alg.TitleToNumber(columnNumber);

            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var columnNumber = "AB";
            var res = alg.TitleToNumber(columnNumber);

            Assert.AreEqual(28, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            var columnNumber = "ZY";
            var res = alg.TitleToNumber(columnNumber);

            Assert.AreEqual(701, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int columnNumber = 2147483647;
            var title = "FXSHRXW";
            var res = alg.TitleToNumber(title);

            Assert.AreEqual(columnNumber, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int columnNumber = 52;
            var title = "AZ";
            var res = alg.TitleToNumber(title);

            Assert.AreEqual(columnNumber, res);
        }
    }
}
