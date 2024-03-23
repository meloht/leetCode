using leetCode._2501_2550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2501_2550
{
    [TestClass]
    public class _2549_CountDistinctNumbersOnBoardUnitTest
    {
        _2549_CountDistinctNumbersOnBoardAlg alg = new _2549_CountDistinctNumbersOnBoardAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 5;
            int exp = 4;
            int res=alg.DistinctIntegers(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 3;
            int exp = 2;
            int res = alg.DistinctIntegers(n);
            Assert.AreEqual(exp, res);
        }
       
    }
}
