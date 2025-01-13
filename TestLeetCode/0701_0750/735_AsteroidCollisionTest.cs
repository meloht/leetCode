using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _735_AsteroidCollisionTest
    {
        _735_AsteroidCollisionAlg alg = new _735_AsteroidCollisionAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] asteroids = [5, 10, -5];
            int[] exp = [5, 10];
            int[] res = alg.AsteroidCollision(asteroids);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] asteroids = [8, -8];
            int[] exp = [];
            int[] res = alg.AsteroidCollision(asteroids);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] asteroids = [10, 2, -5];
            int[] exp = [10];
            int[] res = alg.AsteroidCollision(asteroids);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
