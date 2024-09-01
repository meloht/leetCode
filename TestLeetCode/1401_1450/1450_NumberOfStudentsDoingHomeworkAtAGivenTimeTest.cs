using leetCode._1401_1450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1401_1450
{
    [TestClass]
    public class _1450_NumberOfStudentsDoingHomeworkAtAGivenTimeTest
    {
        _1450_NumberOfStudentsDoingHomeworkAtAGivenTimeAlg alg = new _1450_NumberOfStudentsDoingHomeworkAtAGivenTimeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] startTime = [1, 2, 3], endTime = [3, 2, 7];
            int queryTime = 4;
            int exp = 1;
            int res = alg.BusyStudent(startTime, endTime, queryTime);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] startTime = [4], endTime = [4];
            int queryTime = 4;
            int exp = 1;
            int res = alg.BusyStudent(startTime, endTime, queryTime);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] startTime = [4], endTime = [4];
            int queryTime = 5;
            int exp = 0;
            int res = alg.BusyStudent(startTime, endTime, queryTime);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] startTime = [1, 1, 1, 1], endTime = [1, 3, 2, 4];
            int queryTime = 7;
            int exp = 0;
            int res = alg.BusyStudent(startTime, endTime, queryTime);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] startTime = [9, 8, 7, 6, 5, 4, 3, 2, 1], endTime = [10, 10, 10, 10, 10, 10, 10, 10, 10];
            int queryTime = 5;
            int exp = 5;
            int res = alg.BusyStudent(startTime, endTime, queryTime);
            Assert.AreEqual(exp, res);
        }

    }
}
