using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _841_KeysAndRoomsTest
    {
        _841_KeysAndRoomsAlg alg = new _841_KeysAndRoomsAlg();

        [TestMethod]
        public void TestCase01()
        {
            IList<IList<int>> rooms = [[1], [2], [3], []];
            bool exp = true;
            bool res = alg.CanVisitAllRooms(rooms);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            IList<IList<int>> rooms = [[1, 3], [3, 0, 1], [2], [0]];
            bool exp = false;
            bool res = alg.CanVisitAllRooms(rooms);
            Assert.AreEqual(exp, res);
        }
    }
}
