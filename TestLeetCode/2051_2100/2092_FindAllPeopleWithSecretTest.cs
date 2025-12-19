using leetCode._2051_2100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2051_2100
{
    [TestClass]
    public class _2092_FindAllPeopleWithSecretTest
    {
        _2092_FindAllPeopleWithSecretAlg alg = new _2092_FindAllPeopleWithSecretAlg();

        [TestMethod]
        public void Test01()
        {
            int n = 6;
            int[][] meetings = [[1, 2, 5], [2, 3, 8], [1, 5, 10]];
            int firstPerson = 1;
            int[] exp = [0, 1, 2, 3, 5];
            int[] res = alg.FindAllPeople(n, meetings, firstPerson).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test02()
        {
            int n = 4;
            int[][] meetings = [[3, 1, 3], [1, 2, 2], [0, 3, 3]];
            int firstPerson = 3;
            int[] exp = [0, 1, 3];
            int[] res = alg.FindAllPeople(n, meetings, firstPerson).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test03()
        {
            int n = 5;
            int[][] meetings = [[3, 4, 2], [1, 2, 1], [2, 3, 1]];
            int firstPerson = 1;
            int[] exp = [0, 1, 2, 3, 4];
            int[] res = alg.FindAllPeople(n, meetings, firstPerson).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
