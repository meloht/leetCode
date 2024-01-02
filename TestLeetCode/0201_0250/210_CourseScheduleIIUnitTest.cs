using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _210_CourseScheduleIIUnitTest
    {
        _210_CourseScheduleIIAlg alg = new _210_CourseScheduleIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int numCourses = 2;
            int[][] prerequisites = [[1, 0]];

            var res = alg.FindOrder(numCourses, prerequisites);
            int[] exp = [0, 1];
            Assert.AreEqual(true, exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int numCourses = 4;
            int[][] prerequisites = [[1, 0], [2, 0], [3, 1], [3, 2]];

            var res = alg.FindOrder(numCourses, prerequisites);
            int[][] exp = [[0, 2, 1, 3],[0, 1, 2, 3],[0, 2, 1, 3]];
            bool bl = false;
            foreach (var item in exp)
            {
                if (item.SequenceEqual(res))
                {
                    bl = true;
                    break;
                }
            }
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int numCourses = 1;
            int[][] prerequisites = [];

            var res = alg.FindOrder(numCourses, prerequisites);
            int[] exp = [0];
            Assert.AreEqual(true, exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase04()
        {
            int numCourses = 3;
            int[][] prerequisites = [[1, 0], [1, 2], [0, 1]];

            var res = alg.FindOrder(numCourses, prerequisites);
            int[] exp = [];
            Assert.AreEqual(true, exp.SequenceEqual(res));
        }
    }
}
