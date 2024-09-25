using leetCode._2301_2350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2301_2350
{
    [TestClass]
    public class _2306_NamingACompanyTest
    {
        _2306_NamingACompanyAlg alg = new _2306_NamingACompanyAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] ideas = ["coffee", "donuts", "time", "toffee"];
            long exp = 6;
            long res =alg.DistinctNames(ideas);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] ideas = ["lack", "back"];
            long exp = 0;
            long res = alg.DistinctNames(ideas);
            Assert.AreEqual(exp, res);
        }
    }
}
