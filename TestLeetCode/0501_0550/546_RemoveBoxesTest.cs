using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _546_RemoveBoxesTest
    {
        _546_RemoveBoxesAlg alg = new _546_RemoveBoxesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] boxes = [1, 3, 2, 2, 2, 3, 4, 3, 1];
            int exp = 23;
            int res = alg.RemoveBoxes(boxes);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] boxes = [1, 1, 1];
            int exp = 9;
            int res = alg.RemoveBoxes(boxes);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] boxes = [1];
            int exp = 1;
            int res = alg.RemoveBoxes(boxes);
            Assert.AreEqual(exp, res);
        }
    }
}
