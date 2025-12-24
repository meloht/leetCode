using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3051_3100
{
    [TestClass]
    public class _3074_AppleRedistributionIntoBoxesTest
    {
        _3074_AppleRedistributionIntoBoxesAlg alg = new _3074_AppleRedistributionIntoBoxesAlg();

        [TestMethod]
        public void Test01()
        {
            int[] apple = [1, 3, 2], capacity = [4, 3, 1, 5, 2];
            int exp = 2;
            int res = alg.MinimumBoxes(apple, capacity);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[] apple = [5, 5, 5], capacity = [2, 4, 2, 7];
            int exp = 4;
            int res = alg.MinimumBoxes(apple, capacity);
            Assert.AreEqual(exp, res);
        }
    }
}
