using leetCode._2901_2950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2901_2950
{
    [TestClass]
    public class _2928_DistributeCandiesAmongChildrenIUnitTest
    {
        _2928_DistributeCandiesAmongChildrenIAlg alg = new _2928_DistributeCandiesAmongChildrenIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 5, limit = 2;
            int exp = 3;
            int res = alg.DistributeCandies(n, limit);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 3, limit = 3;
            int exp = 10;
            int res = alg.DistributeCandies(n, limit);
            Assert.AreEqual(exp, res);
        }
    }
}
