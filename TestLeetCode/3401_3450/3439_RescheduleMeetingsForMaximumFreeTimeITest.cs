using leetCode._3401_3450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3401_3450
{
    [TestClass]
    public class _3439_RescheduleMeetingsForMaximumFreeTimeITest
    {
        _3439_RescheduleMeetingsForMaximumFreeTimeIAlg alg = new _3439_RescheduleMeetingsForMaximumFreeTimeIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int eventTime = 5, k = 1;
            int[] startTime = [1, 3], endTime = [2, 5];
            int exp = 2;
            int res = alg.MaxFreeTime(eventTime, k, startTime, endTime);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int eventTime = 10, k = 1;
            int[] startTime = [0, 2, 9], endTime = [1, 4, 10];
            int exp = 6;
            int res = alg.MaxFreeTime(eventTime, k, startTime, endTime);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            int eventTime = 5, k = 2;
            int[] startTime = [0, 1, 2, 3, 4], endTime = [1, 2, 3, 4, 5];
            int exp = 0;
            int res = alg.MaxFreeTime(eventTime, k, startTime, endTime);
            Assert.AreEqual(exp, res);
        }
    }
}
