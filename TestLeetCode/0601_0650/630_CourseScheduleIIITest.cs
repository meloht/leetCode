using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _630_CourseScheduleIIITest
    {
        _630_CourseScheduleIIIAlg alg = new _630_CourseScheduleIIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] courses = [[100, 200], [200, 1300], [1000, 1250], [2000, 3200]];
            int exp = 3;
            int res = alg.ScheduleCourse(courses);
            Assert.AreEqual(exp, res);
                
        }
        [TestMethod]
        public void TestCase02()
        {
            int[][] courses = [[1, 2]];
            int exp = 1;
            int res = alg.ScheduleCourse(courses);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] courses = [[3, 2], [4, 3]];
            int exp = 0;
            int res = alg.ScheduleCourse(courses);
            Assert.AreEqual(exp, res);

        }
    }
}
