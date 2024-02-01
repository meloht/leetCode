using leetCode._51_100;
using leetCode.WeeklyContest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WeeklyContest
{
    [TestClass]
    public class Alg_374_FindPeaks_UnitTest
    {
        Alg_374_FindThePeaks alg;
        [TestInitialize]
        public void Init()
        {
            alg = new Alg_374_FindThePeaks();
        }

        [TestMethod]
        public void TestCase01()
        {
            int[] mountain = { 2, 4, 4 };
            var res = alg.FindPeaks(mountain).ToArray();

            int[] exp = { };
            Array.Sort(exp);
            Array.Sort(res);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] mountain = { 1, 4, 3, 8, 5 };
            var res = alg.FindPeaks(mountain).ToArray();

            int[] exp = { 1, 3 };
            Array.Sort(exp);
            Array.Sort(res);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }


    }
}
