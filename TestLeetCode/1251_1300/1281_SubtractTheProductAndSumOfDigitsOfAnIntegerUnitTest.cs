using leetCode._1251_1300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._1251_1300
{
    [TestClass]
    public class _1281_SubtractTheProductAndSumOfDigitsOfAnIntegerUnitTest
    {
        _1281_SubtractTheProductAndSumOfDigitsOfAnIntegerAlg alg = new _1281_SubtractTheProductAndSumOfDigitsOfAnIntegerAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 234;
            int exp = 15;
            int res = alg.SubtractProductAndSum(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 4421;
            int exp = 21;
            int res = alg.SubtractProductAndSum(n);
            Assert.AreEqual(exp, res);
        }
    }
}
