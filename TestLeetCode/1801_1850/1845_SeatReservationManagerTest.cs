using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._1801_1850._1845_SeatReservationManagerAlg;

namespace Test._1801_1850
{
    [TestClass]
    public class _1845_SeatReservationManagerTest
    {
        [TestMethod]
        public void TestCase01()
        {
            SeatManager seatManager = new SeatManager(5); // 初始化 SeatManager ，有 5 个座位。
            Assert.AreEqual(1,seatManager.Reserve());    // 所有座位都可以预约，所以返回最小编号的座位，也就是 1 。
            Assert.AreEqual(2, seatManager.Reserve());   // 可以预约的座位为 [2,3,4,5] ，返回最小编号的座位，也就是 2 。
            seatManager.Unreserve(2); // 将座位 2 变为可以预约，现在可预约的座位为 [2,3,4,5] 。
            Assert.AreEqual(2, seatManager.Reserve());    // 可以预约的座位为 [2,3,4,5] ，返回最小编号的座位，也就是 2 。
            Assert.AreEqual(3, seatManager.Reserve());    // 可以预约的座位为 [3,4,5] ，返回最小编号的座位，也就是 3 。
            Assert.AreEqual(4, seatManager.Reserve());  // 可以预约的座位为 [4,5] ，返回最小编号的座位，也就是 4 。
            Assert.AreEqual(5, seatManager.Reserve());   // 唯一可以预约的是座位 5 ，所以返回 5 。
            seatManager.Unreserve(5); // 将座位 5 变为可以预约，现在可预约的座位为 [5] 。
        }
    }
}
