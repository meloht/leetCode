using leetCode._1701_1750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1701_1750
{
    [TestClass]
    public class _1705_MaximumNumberOfEatenApplesTest
    {
        _1705_MaximumNumberOfEatenApplesAlg alg = new _1705_MaximumNumberOfEatenApplesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] apples = [1, 2, 3, 5, 2], days = [3, 2, 1, 4, 2];
            int exp = 7;
            int res = alg.EatenApples(apples, days);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] apples = [3, 0, 0, 0, 0, 2], days = [3, 0, 0, 0, 0, 2];
            int exp = 5;
            int res = alg.EatenApples(apples, days);
            Assert.AreEqual(exp, res);
        }
    }
}
