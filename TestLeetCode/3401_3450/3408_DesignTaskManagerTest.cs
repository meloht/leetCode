using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._3401_3450._3408_DesignTaskManagerAlg;

namespace Test._3401_3450
{
    [TestClass]
    public class _3408_DesignTaskManagerTest
    {
        [TestMethod]
        public void Test01()
        {
            TaskManager taskManager = new TaskManager([[1, 101, 10], [2, 102, 20], [3, 103, 15]]); // 分别给用户 1 ，2 和 3 初始化一个任务。
            taskManager.Add(4, 104, 5); // 给用户 4 添加优先级为 5 的任务 104 。
            taskManager.Edit(102, 8); // 更新任务 102 的优先级为 8 。
            Assert.AreEqual(3, taskManager.ExecTop()); // 返回 3 。执行用户 3 的任务 103 。
            taskManager.Rmv(101); // 将系统中的任务 101 删除。
            taskManager.Add(5, 105, 15); // 给用户 5 添加优先级为 15 的任务 105 。
            Assert.AreEqual(5, taskManager.ExecTop()); // 返回 5 。执行用户 5 的任务 105 。
        }
    }
}
