using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _554_BrickWallTest
    {
        _554_BrickWallAlg alg = new _554_BrickWallAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] wall = [[1, 2, 2, 1], [3, 1, 2], [1, 3, 2], [2, 4], [3, 1, 2], [1, 3, 1, 1]];
            int exp = 2;
            int res = alg.LeastBricks(wall);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] wall = [[1], [1], [1]];
            int exp = 3;
            int res = alg.LeastBricks(wall);
            Assert.AreEqual(exp, res);
        }
    }
}
