using leetCode._2151_2200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2151_2200
{
    [TestClass]
    public class _2197_ReplaceNonCoprimeNumbersInArrayTest
    {
        _2197_ReplaceNonCoprimeNumbersInArrayAlg alg = new _2197_ReplaceNonCoprimeNumbersInArrayAlg();

        [TestMethod]
        public void Test01()
        {
            int[] nums = [6, 4, 3, 2, 7, 6, 2];
            int[] exp = [12, 7, 6];
            int[] res = alg.ReplaceNonCoprimes(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test02()
        {
            int[] nums = [2, 2, 1, 1, 3, 3, 3];
            int[] exp = [2, 1, 1, 3];
            int[] res = alg.ReplaceNonCoprimes(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
