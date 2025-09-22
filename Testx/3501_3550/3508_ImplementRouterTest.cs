using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._3501_3550._3508_ImplementRouterAlg;

namespace Testx._3501_3550
{
    public class _3508_ImplementRouterTest
    {
        [Fact]
        public void Test1()
        {
            Router router = new Router(3); // 初始化路由器，内存限制为 3。
            Assert.Equal(router.AddPacket(1, 4, 90), true); // 数据包被添加，返回 True。
            Assert.Equal(router.AddPacket(2, 5, 90), true); // 数据包被添加，返回 True。
            Assert.Equal(router.AddPacket(1, 4, 90), false); // 这是一个重复数据包，返回 False。
            Assert.Equal(router.AddPacket(3, 5, 95), true); // 数据包被添加，返回 True。
            Assert.Equal(router.AddPacket(4, 5, 105), true); // 数据包被添加，[1, 4, 90] 被移除，因为数据包数量超过限制，返回 True。
            var res = router.ForwardPacket(); // 转发数据包 [2, 5, 90] 并将其从路由器中移除。
            Assert.Equal<int>([2, 5, 90], res);
            Assert.Equal(router.AddPacket(5, 2, 110), true); // 数据包被添加，返回 True。
            Assert.Equal(router.GetCount(5, 100, 110), 1); // 唯一目标地址为 5 且时间在 [100, 110] 范围内的数据包是 [4, 5, 105]，返回 1。
        }

        [Fact]
        public void Test2()
        {
            Router router = new Router(2); // 初始化路由器，内存限制为 2。
            Assert.Equal(router.AddPacket(7, 4, 90), true); // 返回 True。
            Assert.Equal([7, 4, 90], router.ForwardPacket()); // 返回 [7, 4, 90]。
            Assert.Equal([], router.ForwardPacket()); // 没有数据包可以转发，返回 []。
        }
    }
}
