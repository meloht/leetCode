using leetCode._3401_3450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3401_3450
{
    [TestClass]
    public class _3445_MaximumDifferenceBetweenEvenAndOddFrequencyIITest
    {
        _3445_MaximumDifferenceBetweenEvenAndOddFrequencyIIAlg alg = new _3445_MaximumDifferenceBetweenEvenAndOddFrequencyIIAlg();

        [TestMethod]
        public void Test01()
        {
            string s = "12233";
            int k = 4;
            int exp = -1;
            int res = alg.MaxDifference(s, k);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void Test02()
        {
            string s = "1122211";
            int k = 3;
            int exp = 1;
            int res = alg.MaxDifference(s, k);
            Assert.AreEqual(exp, res);

        }
        [TestMethod]
        public void Test03()
        {
            string s = "110";
            int k = 3;
            int exp = -1;
            int res = alg.MaxDifference(s, k);
            Assert.AreEqual(exp, res);

        }
    }



}
