using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _636_ExclusiveTimeOfFunctionsTest
    {
        _636_ExclusiveTimeOfFunctionsAlg alg = new _636_ExclusiveTimeOfFunctionsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            string[] logs = ["0:start:0", "1:start:2", "1:end:5", "0:end:6"];
            int[] exp = [3, 4];
            int[] res = alg.ExclusiveTime(n, logs);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            string[] logs = ["0:start:0", "0:start:2", "0:end:5", "0:start:6", "0:end:6", "0:end:7"];
            int[] exp = [8];
            int[] res = alg.ExclusiveTime(n, logs);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 2;
            string[] logs = ["0:start:0", "0:start:2", "0:end:5", "1:start:6", "1:end:6", "0:end:7"];
            int[] exp = [7, 1];
            int[] res = alg.ExclusiveTime(n, logs);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
