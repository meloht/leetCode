using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0851_0900._855_ExamRoomAlg;

namespace Test._0851_0900
{
    [TestClass]
    public class _855_ExamRoomTest
    {
        [TestMethod]
        public void TestCase01()
        {
            ExamRoom examRoom = new ExamRoom(10);
            Assert.AreEqual(0, examRoom.Seat()); // 返回 0，房间里没有人，学生坐在 0 号座位。
            Assert.AreEqual(9, examRoom.Seat()); // 返回 9，学生最后坐在 9 号座位。
            Assert.AreEqual(4, examRoom.Seat()); // 返回 4，学生最后坐在 4 号座位。
            Assert.AreEqual(2, examRoom.Seat()); // 返回 2，学生最后坐在 2 号座位。
            examRoom.Leave(4);
            Assert.AreEqual(5, examRoom.Seat()); // 返回 5，学生最后坐在 5 号座位。
        }
    }
}
