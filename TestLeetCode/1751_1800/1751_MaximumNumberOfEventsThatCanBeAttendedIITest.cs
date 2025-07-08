using leetCode._1751_1800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1751_1800
{
    [TestClass]
    public class _1751_MaximumNumberOfEventsThatCanBeAttendedIITest
    {
        _1751_MaximumNumberOfEventsThatCanBeAttendedIIAlg alg = new _1751_MaximumNumberOfEventsThatCanBeAttendedIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] events = [[1, 2, 4], [3, 4, 3], [2, 3, 1]];
            int k = 2;
            int exp = 7;
            int res = alg.MaxValue(events, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] events = [[1, 2, 4], [3, 4, 3], [2, 3, 10]];
            int k = 2;
            int exp = 10;
            int res = alg.MaxValue(events, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] events = [[1, 1, 1], [2, 2, 2], [3, 3, 3], [4, 4, 4]];
            int k = 3;
            int exp = 9;
            int res = alg.MaxValue(events, k);
            Assert.AreEqual(exp, res);
        }
    }
}
