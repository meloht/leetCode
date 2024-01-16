using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2701_2750
{
    [TestClass]
    public class _2719_CountOfIntegersUnitTest
    {
        _2719_CountOfIntegersAlg alg = new _2719_CountOfIntegersAlg();

        [TestMethod]
        public void TestCase01()
        {
            string num1 = "1", num2 = "12";
            int min_num = 1, max_num = 8;
            int exp = 11;
            int res = alg.Count(num1, num2, min_num, max_num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string num1 = "1", num2 = "5";
            int min_num = 1, max_num = 5;
            int exp = 5;
            int res = alg.Count(num1, num2, min_num, max_num);
            Assert.AreEqual(exp, res);
        }
    }
}
