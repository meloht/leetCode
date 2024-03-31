using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1039_MinimumScoreTriangulationOfPolygonUnitTest
    {
        _1039_MinimumScoreTriangulationOfPolygonAlg alg = new _1039_MinimumScoreTriangulationOfPolygonAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] values = [1, 2, 3];
            int exp = 6;
            int res = alg.MinScoreTriangulation(values);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[] values = [3, 7, 4, 5];
            int exp = 144;
            int res = alg.MinScoreTriangulation(values);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] values = [1, 3, 1, 4, 1, 5];
            int exp = 13;
            int res = alg.MinScoreTriangulation(values);
            Assert.AreEqual(exp, res);
        }
    }
}
