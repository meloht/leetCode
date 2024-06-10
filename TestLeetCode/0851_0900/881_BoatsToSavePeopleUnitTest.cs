using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _881_BoatsToSavePeopleUnitTest
    {
        _881_BoatsToSavePeopleAlg alg = new _881_BoatsToSavePeopleAlg();

        [TestMethod]
        public void Test1()
        {
            int[] people = [1, 2];
            int limit = 3;
            int exp = 1;
            int res = alg.NumRescueBoats(people, limit);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test2()
        {
            int[] people = [3, 2, 2, 1];
            int limit = 3;
            int exp = 3;
            int res = alg.NumRescueBoats(people, limit);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test3()
        {
            int[] people = [3, 5, 3, 4];
            int limit = 5;
            int exp = 4;
            int res = alg.NumRescueBoats(people, limit);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test4()
        {
            int[] people = [5, 1, 4, 2];
            int limit = 6;
            int exp = 2;
            int res = alg.NumRescueBoats(people, limit);
            Assert.AreEqual(exp, res);
        }
    }
}
