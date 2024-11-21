using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3248_SnakeInMatrixTest
    {
        _3248_SnakeInMatrixAlg alg = new _3248_SnakeInMatrixAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            string[] commands = ["RIGHT", "DOWN"];
            int exp = 3;
            int res = alg.FinalPositionOfSnake(n, commands);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 3;
            string[] commands = ["DOWN", "RIGHT", "UP"];
            int exp = 1;
            int res = alg.FinalPositionOfSnake(n, commands);
            Assert.AreEqual(exp, res);
        }
    }
}
