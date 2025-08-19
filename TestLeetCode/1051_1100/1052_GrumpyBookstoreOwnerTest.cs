using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1051_1100
{
    [TestClass]
    public class _1052_GrumpyBookstoreOwnerTest
    {
        _1052_GrumpyBookstoreOwnerAlg alg = new _1052_GrumpyBookstoreOwnerAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] customers = [1, 0, 1, 2, 1, 1, 7, 5], grumpy = [0, 1, 0, 1, 0, 1, 0, 1];
            int minutes = 3;
            int exp = 16;
            int res = alg.MaxSatisfied(customers, grumpy, minutes);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] customers = [1], grumpy = [0];
            int minutes = 1;
            int exp = 1;
            int res = alg.MaxSatisfied(customers, grumpy, minutes);
            Assert.AreEqual(exp, res);

        }
    }
}
