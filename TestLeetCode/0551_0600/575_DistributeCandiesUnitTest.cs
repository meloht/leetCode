using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _575_DistributeCandiesUnitTest
    {
        _575_DistributeCandiesAlg alg = new _575_DistributeCandiesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] candyType = [1, 1, 2, 2, 3, 3];
            int exp = 3;
            int res = alg.DistributeCandies(candyType);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] candyType = [1, 1, 2, 3];
            int exp = 2;
            int res = alg.DistributeCandies(candyType);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            int[] candyType = [6, 6, 6, 6];
            int exp = 1;
            int res = alg.DistributeCandies(candyType);
            Assert.AreEqual(exp, res);
        }
    }
}
