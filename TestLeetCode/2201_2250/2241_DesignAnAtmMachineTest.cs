using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._2201_2250._2241_DesignAnAtmMachineAlg;

namespace Test._2201_2250
{
    [TestClass]
    public class _2241_DesignAnAtmMachineTest
    {
        [TestMethod]
        public void TestCase01()
        {
            int[] exp = [0, 0, 1, 0, 1];
            int[] res = [-1];
            ATM atm = new ATM();
            atm.Deposit([0, 0, 1, 2, 1]); // 存入 1 张 $100 ，2 张 $200 和 1 张 $500 的钞票。
            res = atm.Withdraw(600);        // 返回 [0,0,1,0,1] 。机器返回 1 张 $100 和 1 张 $500 的钞票。机器里剩余钞票的数量为 [0,0,0,2,0] 。
            Assert.IsTrue(exp.SequenceEqual(res));
            atm.Deposit([0, 1, 0, 1, 1]); // 存入 1 张 $50 ，1 张 $200 和 1 张 $500 的钞票。
                                          // 机器中剩余钞票数量为 [0,1,0,3,1] 。
            res = atm.Withdraw(600);        // 返回 [-1] 。机器会尝试取出 $500 的钞票，然后无法得到剩余的 $100 ，所以取款请求会被拒绝。
                                            // 由于请求被拒绝，机器中钞票的数量不会发生改变。
            exp = [-1];
            Assert.IsTrue(exp.SequenceEqual(res));
            exp = [0, 1, 0, 0, 1];
            res = atm.Withdraw(550);        // 返回 [0,1,0,0,1] ，机器会返回 1 张 $50 的钞票和 1 张 $500 的钞票。
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
