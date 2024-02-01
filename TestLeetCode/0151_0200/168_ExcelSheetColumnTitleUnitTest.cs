using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0151_0200
{
    [TestClass]
    public class _168_ExcelSheetColumnTitleUnitTest
    {
        _168_ExcelSheetColumnTitleAlg alg = new _168_ExcelSheetColumnTitleAlg();

        [TestMethod]
        public void TestCase01()
        {
            int columnNumber = 1;
            var res=alg.ConvertToTitle(columnNumber);

            Assert.AreEqual("A", res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int columnNumber = 28;
            var res = alg.ConvertToTitle(columnNumber);

            Assert.AreEqual("AB", res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int columnNumber = 701;
            var res = alg.ConvertToTitle(columnNumber);

            Assert.AreEqual("ZY", res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int columnNumber = 2147483647;
            var res = alg.ConvertToTitle(columnNumber);

            Assert.AreEqual("FXSHRXW", res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int columnNumber = 52;
            var res = alg.ConvertToTitle(columnNumber);

            Assert.AreEqual("AZ", res);
        }
    }
}
