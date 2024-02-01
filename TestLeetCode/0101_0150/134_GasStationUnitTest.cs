using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _134_GasStationUnitTest
    {
        _134_GasStationAlg alg = new _134_GasStationAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] gas = [1, 2, 3, 4, 5], cost = [3, 4, 5, 1, 2];
            int res = alg.CanCompleteCircuit(gas, cost);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] gas = [2, 3, 4], cost = [3, 4, 3];
            int res = alg.CanCompleteCircuit(gas, cost);
            Assert.AreEqual(-1, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] gas = [4, 5, 2, 6, 5, 3], cost = [3, 2, 7, 3, 2, 9];
            int res = alg.CanCompleteCircuit(gas, cost);

            Assert.AreEqual(-1, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] gas = [2], cost = [2];
            int res = alg.CanCompleteCircuit(gas, cost);

            Assert.AreEqual(0, res);
        }
    }
}
