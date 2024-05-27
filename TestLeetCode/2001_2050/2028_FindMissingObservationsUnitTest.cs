using leetCode._2001_2050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2001_2050
{
    [TestClass]
    public class _2028_FindMissingObservationsUnitTest
    {
        _2028_FindMissingObservationsAlg alg = new _2028_FindMissingObservationsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] rolls = [3, 2, 4, 3];
            int mean = 4, n = 2;
            int[] exp = [6, 6];
            int[] res = alg.MissingRolls(rolls, mean, n);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] rolls = [1, 5, 6];
            int mean = 3, n = 4;
            int[] exp = [2, 3, 2, 2];
            int[] res = alg.MissingRolls(rolls, mean, n);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] rolls = [1, 2, 3, 4];
            int mean = 6, n = 4;
            int[] exp = [];
            int[] res = alg.MissingRolls(rolls, mean, n);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] rolls = [1];
            int mean = 3, n = 1;
            int[] exp = [5];
            int[] res = alg.MissingRolls(rolls, mean, n);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
