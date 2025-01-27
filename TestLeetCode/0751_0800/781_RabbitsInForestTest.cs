using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _781_RabbitsInForestTest
    {
        _781_RabbitsInForestAlg alg=new _781_RabbitsInForestAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] answers = [1, 1, 2];
            int exp = 5;
            int res = alg.NumRabbits(answers);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] answers = [10, 10, 10];
            int exp = 11;
            int res = alg.NumRabbits(answers);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int[] answers = [1, 0, 1, 0, 0];
            int exp = 5;
            int res = alg.NumRabbits(answers);
            Assert.AreEqual(exp, res);
        }
    }
}
