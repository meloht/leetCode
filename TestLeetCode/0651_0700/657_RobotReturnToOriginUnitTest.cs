using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _657_RobotReturnToOriginUnitTest
    {
        _657_RobotReturnToOriginAlg alg = new _657_RobotReturnToOriginAlg();

        [TestMethod]
        public void TestCase01()
        {
            string moves = "UD";
            bool exp = true;
            bool res = alg.JudgeCircle(moves);
            Assert.AreEqual(res, exp);
        }

        [TestMethod]
        public void TestCase02()
        {
            string moves = "LL";
            bool exp = false;
            bool res = alg.JudgeCircle(moves);
            Assert.AreEqual(res, exp);
        }
    }
}
