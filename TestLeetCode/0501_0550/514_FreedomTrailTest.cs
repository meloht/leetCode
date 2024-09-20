using leetCode._0501_0550;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _514_FreedomTrailTest
    {
        _514_FreedomTrailAlg alg = new _514_FreedomTrailAlg();
        [TestMethod]
        public void TestCase01()
        {
            string ring = "godding", key = "gd";
            int exp = 4;
            int res = alg.FindRotateSteps(ring, key);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            string ring = "godding", key = "godding";
            int exp = 13;
            int res = alg.FindRotateSteps(ring, key);
            Assert.AreEqual(exp, res);
        }
    }
}
