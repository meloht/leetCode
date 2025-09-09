using leetCode._2301_2350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2301_2350
{
    [TestClass]
    public class _2327_NumberOfPeopleAwareOfASecretTest
    {
        _2327_NumberOfPeopleAwareOfASecretAlg alg = new _2327_NumberOfPeopleAwareOfASecretAlg();

        [TestMethod]
        public void Test01()
        {
            int n = 6, delay = 2, forget = 4;
            int exp = 5;
            int res = alg.PeopleAwareOfSecret(n, delay, forget);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int n = 4, delay = 1, forget = 3;
            int exp = 6;
            int res = alg.PeopleAwareOfSecret(n, delay, forget);
            Assert.AreEqual(exp, res);
        }


    }
}
