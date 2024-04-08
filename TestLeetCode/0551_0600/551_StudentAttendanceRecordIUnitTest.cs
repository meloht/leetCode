using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _551_StudentAttendanceRecordIUnitTest
    {
        _551_StudentAttendanceRecordIAlg alg = new _551_StudentAttendanceRecordIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "PPALLP";
            bool exp = true;
            bool res = alg.CheckRecord(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "PPALLL";
            bool exp = false;
            bool res = alg.CheckRecord(s);
            Assert.AreEqual(exp, res);
        }
    }
}
