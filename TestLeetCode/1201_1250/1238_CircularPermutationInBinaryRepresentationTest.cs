using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1201_1250
{
    [TestClass]
    public class _1238_CircularPermutationInBinaryRepresentationTest
    {
        _1238_CircularPermutationInBinaryRepresentationAlg alg = new _1238_CircularPermutationInBinaryRepresentationAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 2, start = 3;
            int[] exp = [3, 2, 0, 1];
            int[] res = alg.CircularPermutation(n, start).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 3, start = 2;
            int[] exp = [2, 6, 7, 5, 4, 0, 1, 3];
            int[] res = alg.CircularPermutation(n, start).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
