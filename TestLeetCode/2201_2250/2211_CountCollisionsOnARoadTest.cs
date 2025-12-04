using leetCode._2201_2250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2201_2250
{
    [TestClass]
    public class _2211_CountCollisionsOnARoadTest
    {
        _2211_CountCollisionsOnARoadAlg alg = new _2211_CountCollisionsOnARoadAlg();
       
        [TestMethod]
        public void TestCase01()
        {
            string directions = "RLRSLL";
            int exp = 5;
            int res = alg.CountCollisions(directions);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string directions = "LLRR";
            int exp = 0;
            int res = alg.CountCollisions(directions);
            Assert.AreEqual(exp, res);
        }
    }
}
