using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WeeklyContest._0401
{
    [TestClass]
    public class Test_01
    {
        Alg_01 alg = new Alg_01();

        [TestMethod]
        public void Test1()
        {
            int n = 3, k = 5;
            int exp = 1;
            int res = alg.NumberOfChild(n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test2()
        {
            int n = 5, k = 6;
            int exp = 2;
            int res = alg.NumberOfChild(n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test3()
        {
            int n = 4, k = 2;
            int exp = 2;
            int res = alg.NumberOfChild(n, k);
            Assert.AreEqual(exp, res);
        }

       
    }
}
