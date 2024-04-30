using leetCode._2751_2800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2751_2800
{
    [TestClass]
    public class _2798_NumberOfEmployeesWhoMetTheTargetUnitTest
    {
        _2798_NumberOfEmployeesWhoMetTheTargetAlg alg = new _2798_NumberOfEmployeesWhoMetTheTargetAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] hours = [0, 1, 2, 3, 4];
            int target = 2;
            int exp = 3;
            int res = alg.NumberOfEmployeesWhoMetTarget(hours, target);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[] hours = [5, 1, 4, 2, 2];
            int target = 6;
            int exp = 0;
            int res = alg.NumberOfEmployeesWhoMetTarget(hours, target);
            Assert.AreEqual(exp, res);
        }
    }
}
