using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _748_ShortestCompletingWordUnitTest
    {
        _748_ShortestCompletingWordAlg alg = new _748_ShortestCompletingWordAlg();

        [TestMethod]
        public void TestCase01()
        {
            string licensePlate = "1s3 PSt";
            string[] words = ["step", "steps", "stripe", "stepple"];
            string exp = "steps";
            string res = alg.ShortestCompletingWord(licensePlate, words);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string licensePlate = "1s3 456";
            string[] words = ["looks", "pest", "stew", "show"];
            string exp = "pest";
            string res = alg.ShortestCompletingWord(licensePlate, words);
            Assert.AreEqual(exp, res);
        }
    }
}
