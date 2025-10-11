using leetCode._3151_3200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_3200
{
    [TestClass]
    public class _3186_MaximumTotalDamageWithSpellCastingTest
    {
        _3186_MaximumTotalDamageWithSpellCastingAlg alg = new _3186_MaximumTotalDamageWithSpellCastingAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] power = [1, 1, 3, 4];
            long exp = 6;
            long res = alg.MaximumTotalDamage(power);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] power = [7, 1, 6, 6];
            long exp = 13;
            long res = alg.MaximumTotalDamage(power);
            Assert.AreEqual(exp, res);
        }
    }
}
