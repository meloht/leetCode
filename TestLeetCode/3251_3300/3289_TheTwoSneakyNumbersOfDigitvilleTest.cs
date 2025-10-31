using leetCode._3251_3300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3251_3300
{
    [TestClass]
    public class _3289_TheTwoSneakyNumbersOfDigitvilleTest
    {
        _3289_TheTwoSneakyNumbersOfDigitvilleAlg alg = new _3289_TheTwoSneakyNumbersOfDigitvilleAlg();

        [TestMethod]
        public void Test01()
        {
            int[] nums = [0, 1, 1, 0];
            int[] exp = [1, 0];
            int[] res = alg.GetSneakyNumbers(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test02()
        {
            int[] nums = [0, 3, 2, 1, 3, 2];
            int[] exp = [3, 2];
            int[] res = alg.GetSneakyNumbers(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test03()
        {
            int[] nums = [7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2];
            int[] exp = [4, 5];
            int[] res = alg.GetSneakyNumbers(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
