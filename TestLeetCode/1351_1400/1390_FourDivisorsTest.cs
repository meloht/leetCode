using leetCode._1351_1400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1351_1400
{
    [TestClass]
    public class _1390_FourDivisorsTest
    {
        _1390_FourDivisorsAlg alg = new _1390_FourDivisorsAlg();

        [TestMethod]
        public void Test01()
        {
            int[] nums = [21, 4, 7];
            int exp = 32;
            int res= alg.SumFourDivisors(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[] nums = [21, 21];
            int exp = 64;
            int res = alg.SumFourDivisors(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            int[] nums = [1, 2, 3, 4, 5];
            int exp = 0;
            int res = alg.SumFourDivisors(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
