using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0901_0950._933_NumberOfRecentCallsAlg;

namespace Test._0901_0950
{
    [TestClass]
    public class _933_NumberOfRecentCallsUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            RecentCounter recentCounter = new RecentCounter();
            Assert.AreEqual(1, recentCounter.Ping(1));     // requests = [1]，范围是 [-2999,1]，返回 1
            Assert.AreEqual(2, recentCounter.Ping(100));   // requests = [1, 100]，范围是 [-2900,100]，返回 2
            Assert.AreEqual(3, recentCounter.Ping(3001));  // requests = [1, 100, 3001]，范围是 [1,3001]，返回 3
            Assert.AreEqual(3, recentCounter.Ping(3002));  // requests = [1, 100, 3001, 3002]，范围是 [2,3002]，返回 3
        }
    }
}
