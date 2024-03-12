using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _461_HammingDistanceUnitTest
    {
        _461_HammingDistanceAlg alg = new _461_HammingDistanceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int x = 1, y = 4;
            int exp = 2;
            int res=alg.HammingDistance(x,y);
            Assert.AreEqual(exp,res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int x = 3, y = 1;
            int exp = 1;
            int res = alg.HammingDistance(x, y);
            Assert.AreEqual(exp, res);
        }
    }
}
