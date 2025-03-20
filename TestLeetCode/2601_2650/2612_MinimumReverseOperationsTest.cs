using leetCode._2601_2650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2601_2650
{
    [TestClass]
    public class _2612_MinimumReverseOperationsTest
    {
        _2612_MinimumReverseOperationsAlg alg = new _2612_MinimumReverseOperationsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 4, p = 0;
            int[] banned = [1, 2];
            int k = 4;
            int[] exp = [0, -1, -1, 1];
            int[] res = alg.MinReverseOperations(n, p, banned, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 5, p = 0;
            int[] banned = [2, 4];
            int k = 3;
            int[] exp = [0, -1, -1, -1, -1];
            int[] res = alg.MinReverseOperations(n, p, banned, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
