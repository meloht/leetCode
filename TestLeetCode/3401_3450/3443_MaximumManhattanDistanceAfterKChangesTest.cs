using leetCode._3401_3450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3401_3450
{
    [TestClass]
    public class _3443_MaximumManhattanDistanceAfterKChangesTest
    {
        _3443_MaximumManhattanDistanceAfterKChangesAlg alg = new _3443_MaximumManhattanDistanceAfterKChangesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "NWSE";
            int k = 1;
            int exp = 3;
            int res = alg.MaxDistance(s,k);
            Assert.AreEqual(exp,res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "NSWWEW";
            int k = 3;
            int exp = 6;
            int res = alg.MaxDistance(s, k);
            Assert.AreEqual(exp, res);
        }
    }
}
