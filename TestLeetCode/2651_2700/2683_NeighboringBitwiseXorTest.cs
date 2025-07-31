using leetCode._2651_2700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2651_2700
{
    [TestClass]
    public class _2683_NeighboringBitwiseXorTest
    {
        _2683_NeighboringBitwiseXorAlg alg = new _2683_NeighboringBitwiseXorAlg();

        [TestMethod]
        public void Test01()
        {
            int[] derived = [1, 1, 0];
            bool exp = true;
            bool res = alg.DoesValidArrayExist(derived);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[] derived = [1, 1];
            bool exp = true;
            bool res = alg.DoesValidArrayExist(derived);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            int[] derived = [1, 0];
            bool exp = false;
            bool res = alg.DoesValidArrayExist(derived);
            Assert.AreEqual(exp, res);
        }
    }
}
