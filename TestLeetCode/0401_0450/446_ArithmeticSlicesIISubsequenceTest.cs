using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _446_ArithmeticSlicesIISubsequenceTest
    {
        _446_ArithmeticSlicesIISubsequenceAlg alg = new _446_ArithmeticSlicesIISubsequenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 4, 6, 8, 10];
            int exp = 7;
            int res=alg.NumberOfArithmeticSlices(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [7, 7, 7, 7, 7];
            int exp = 16;
            int res = alg.NumberOfArithmeticSlices(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
