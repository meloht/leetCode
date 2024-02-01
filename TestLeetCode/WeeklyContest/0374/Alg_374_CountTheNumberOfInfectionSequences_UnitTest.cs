using leetCode.WeeklyContest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WeeklyContest
{
    [TestClass]
    public class Alg_374_CountTheNumberOfInfectionSequences_UnitTest
    {
        Alg_374_CountTheNumberOfInfectionSequences alg;
        [TestInitialize]
        public void Init()
        {
            alg = new Alg_374_CountTheNumberOfInfectionSequences();
        }

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = { 0, 4 };
            int res = alg.NumberOfSequence(5, arr);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = { 1 };
            int res = alg.NumberOfSequence(4, arr);
            Assert.AreEqual(3, res);
        }

    }
}
