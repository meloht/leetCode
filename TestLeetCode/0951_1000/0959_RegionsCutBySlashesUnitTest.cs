using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0951_1000
{
    [TestClass]
    public class _0959_RegionsCutBySlashesUnitTest
    {
        _0959_RegionsCutBySlashesAlg alg = new _0959_RegionsCutBySlashesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] grid = [" /", "/ "];
            int exp = 2;
            int res = alg.RegionsBySlashes(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] grid = [" /", "  "];
            int exp = 1;
            int res = alg.RegionsBySlashes(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] grid = ["/\\", "\\/"];
            int exp = 5;
            int res = alg.RegionsBySlashes(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
