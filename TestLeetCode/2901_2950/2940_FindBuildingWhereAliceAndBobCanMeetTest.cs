using leetCode._2901_2950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2901_2950
{
    [TestClass]
    public class _2940_FindBuildingWhereAliceAndBobCanMeetTest
    {
        _2940_FindBuildingWhereAliceAndBobCanMeetAlg alg = new _2940_FindBuildingWhereAliceAndBobCanMeetAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] heights = [6, 4, 8, 5, 2, 7];
            int[][] queries = [[0, 1], [0, 3], [2, 4], [3, 4], [2, 2]];
            int[] exp = [2, 5, -1, 5, 2];
            int[] res = alg.LeftmostBuildingQueries(heights, queries);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] heights = [5, 3, 8, 2, 6, 1, 4, 6];
            int[][] queries = [[0, 7], [3, 5], [5, 2], [3, 0], [1, 6]];
            int[] exp = [7, 6, -1, 4, 6];
            int[] res = alg.LeftmostBuildingQueries(heights, queries);
            Assert.IsTrue(exp.SequenceEqual(res));

        }


    }
}
