using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._1_50
{
    [TestClass]
    public class _38_CountAndSayUnitTest
    {
        _38_CountAndSayAlg alg = new _38_CountAndSayAlg();
        [TestMethod]
        public void TestCase01()
        {

            var index = alg.CountAndSay(1);

            Assert.AreEqual("1", index);

        }
        [TestMethod]
        public void TestCase02()
        {

            var index = alg.CountAndSay(4);

            Assert.AreEqual("1211", index);

        }
    }
}
