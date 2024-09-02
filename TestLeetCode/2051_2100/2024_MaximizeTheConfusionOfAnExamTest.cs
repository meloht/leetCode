using leetCode._2051_2100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2051_2100
{
    [TestClass]
    public class _2024_MaximizeTheConfusionOfAnExamTest
    {
        _2024_MaximizeTheConfusionOfAnExamAlg alg = new _2024_MaximizeTheConfusionOfAnExamAlg();

        [TestMethod]
        public void TestCase01()
        {
            string answerKey = "TTFF";
            int k = 2;
            int exp = 4;
            int res = alg.MaxConsecutiveAnswers(answerKey, k);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            string answerKey = "TFFT";
            int k = 1;
            int exp = 3;
            int res = alg.MaxConsecutiveAnswers(answerKey, k);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase03()
        {
            string answerKey = "TTFTTFTT";
            int k = 1;
            int exp = 5;
            int res = alg.MaxConsecutiveAnswers(answerKey, k);
            Assert.AreEqual(exp, res);

        }
    }
}
