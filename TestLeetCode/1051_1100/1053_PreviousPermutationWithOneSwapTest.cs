using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1051_1100
{
    [TestClass]
    public class _1053_PreviousPermutationWithOneSwapTest
    {
        _1053_PreviousPermutationWithOneSwapAlg alg = new _1053_PreviousPermutationWithOneSwapAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [3, 2, 1];
            int[] exp = [3, 1, 2];
            int[] res = alg.PrevPermOpt1(arr);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, 1, 5];
            int[] exp = [1, 1, 5];
            int[] res = alg.PrevPermOpt1(arr);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [1, 9, 4, 6, 7];
            int[] exp = [1, 7, 4, 6, 9];
            int[] res = alg.PrevPermOpt1(arr);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
