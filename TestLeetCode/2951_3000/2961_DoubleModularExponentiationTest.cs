using leetCode._2951_3000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2951_3000
{
    [TestClass]
    public class _2961_DoubleModularExponentiationTest
    {
        _2961_DoubleModularExponentiationAlg alg = new _2961_DoubleModularExponentiationAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] variables = [[2, 3, 3, 10], [3, 3, 3, 1], [6, 1, 1, 4]];
            int target = 2;
            int[] exp = [0, 2];
            int[] res = alg.GetGoodIndices(variables, target).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] variables = [[39, 3, 1000, 1000]];
            int target = 17;
            int[] exp = [];
            int[] res = alg.GetGoodIndices(variables, target).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
