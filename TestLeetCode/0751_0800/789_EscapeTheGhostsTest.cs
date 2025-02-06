using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _789_EscapeTheGhostsTest
    {
        _789_EscapeTheGhostsAlg alg = new _789_EscapeTheGhostsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] ghosts = [[1, 0], [0, 3]];
            int[] target = [0, 1];
            bool exp = true;
            bool res=alg.EscapeGhosts(ghosts, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] ghosts = [[1, 0]];
            int[] target = [2, 0];
            bool exp = false;
            bool res = alg.EscapeGhosts(ghosts, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] ghosts = [[2, 0]];
            int[] target = [1, 0];
            bool exp = false;
            bool res = alg.EscapeGhosts(ghosts, target);
            Assert.AreEqual(exp, res);
        }

    }
}
