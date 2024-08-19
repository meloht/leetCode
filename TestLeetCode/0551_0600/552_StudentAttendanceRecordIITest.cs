using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _552_StudentAttendanceRecordIITest
    {
        _552_StudentAttendanceRecordIIAlg alg = new _552_StudentAttendanceRecordIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            int exp = 8;
            int res = alg.CheckRecord(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            int exp = 3;
            int res = alg.CheckRecord(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 10101;
            int exp = 183236316;
            int res = alg.CheckRecord(n);
            Assert.AreEqual(exp, res);
        }
    }
}
