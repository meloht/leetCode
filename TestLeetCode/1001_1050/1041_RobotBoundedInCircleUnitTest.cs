using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1041_RobotBoundedInCircleUnitTest
    {
        _1041_RobotBoundedInCircleAlg alg = new _1041_RobotBoundedInCircleAlg();

        [TestMethod]
        public void TestCase01()
        {
            string instructions = "GGLLGG";
            bool exp = true;
            bool res = alg.IsRobotBounded(instructions);
            Assert.AreEqual(res, exp);
        }

        [TestMethod]
        public void TestCase02()
        {
            string instructions = "GG";
            bool exp = false;
            bool res = alg.IsRobotBounded(instructions);
            Assert.AreEqual(res, exp);
        }

        [TestMethod]
        public void TestCase03()
        {
            string instructions = "GL";
            bool exp = true;
            bool res = alg.IsRobotBounded(instructions);
            Assert.AreEqual(res, exp);
        }
    }
}
