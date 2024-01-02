using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _207_CourseScheduleUnitTest
    {
        _207_CourseScheduleAlg alg = new _207_CourseScheduleAlg();

        [TestMethod]
        public void TestCase01()
        {
            int numCourses = 2;
            int[][] prerequisites = [[1, 0]];

            var res = alg.CanFinish(numCourses, prerequisites);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int numCourses = 2;
            int[][] prerequisites = [[1, 0], [0, 1]];

            var res = alg.CanFinish(numCourses, prerequisites);
            Assert.AreEqual(false, res);
        }
    }
}
