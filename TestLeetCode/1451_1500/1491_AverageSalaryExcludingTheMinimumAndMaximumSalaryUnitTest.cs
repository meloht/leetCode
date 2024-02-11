using leetCode._1451_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1451_1500
{
    [TestClass]
    public class _1491_AverageSalaryExcludingTheMinimumAndMaximumSalaryUnitTest
    {
        _1491_AverageSalaryExcludingTheMinimumAndMaximumSalaryAlg alg = new _1491_AverageSalaryExcludingTheMinimumAndMaximumSalaryAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[] salary = [4000, 3000, 1000, 2000];
            double exp = 2500.00000;
            double res = alg.Average(salary);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] salary = [1000, 2000, 3000];
            double exp = 2000.00000;
            double res = alg.Average(salary);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] salary = [6000, 5000, 4000, 3000, 2000, 1000];
            double exp = 3500.00000;
            double res = alg.Average(salary);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] salary = [8000, 9000, 2000, 3000, 6000, 1000];
            double exp = 4750.00000;
            double res = alg.Average(salary);
            Assert.AreEqual(exp, res);
        }
    }

}
