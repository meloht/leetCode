using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _849_MaximizeDistanceToClosestPersonTest
    {
        _849_MaximizeDistanceToClosestPersonAlg alg = new _849_MaximizeDistanceToClosestPersonAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] seats = [1, 0, 0, 0, 1, 0, 1];
            int exp = 2;
            int res = alg.MaxDistToClosest(seats);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] seats = [1, 0, 0, 0];
            int exp = 3;
            int res = alg.MaxDistToClosest(seats);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] seats = [0, 1];
            int exp = 1;
            int res = alg.MaxDistToClosest(seats);
            Assert.AreEqual(exp, res);
        }
    }
}
