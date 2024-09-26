using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _517_SuperWashingMachinesTest
    {
        _517_SuperWashingMachinesAlg alg = new _517_SuperWashingMachinesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] machines = [1, 0, 5];
            int exp = 3;
            int res = alg.FindMinMoves(machines);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] machines = [0, 3, 0];
            int exp = 2;
            int res = alg.FindMinMoves(machines);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] machines = [0, 2, 0];
            int exp = -1;
            int res = alg.FindMinMoves(machines);
            Assert.AreEqual(exp, res);
        }
    }
}
