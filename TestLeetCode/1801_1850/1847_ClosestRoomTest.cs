using leetCode._1801_1850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1801_1850
{
    [TestClass]
    public class _1847_ClosestRoomTest
    {
        _1847_ClosestRoomAlg alg = new _1847_ClosestRoomAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] rooms = [[2, 2], [1, 2], [3, 2]], queries = [[3, 1], [3, 3], [5, 2]];
            int[] exp = [3, -1, 3];
            int[] res = alg.ClosestRoom(rooms, queries);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] rooms = [[1, 4], [2, 3], [3, 5], [4, 1], [5, 2]], queries = [[2, 3], [2, 4], [2, 5]];
            int[] exp = [2, 1, 3];
            int[] res = alg.ClosestRoom(rooms, queries);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
