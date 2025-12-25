using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3051_3100
{
    [TestClass]
    public class _3075_MaximizeHappinessOfSelectedChildrenTest
    {
        _3075_MaximizeHappinessOfSelectedChildrenAlg alg = new _3075_MaximizeHappinessOfSelectedChildrenAlg();

        [TestMethod]
        public void Test01()
        {
            int[] happiness = [1, 2, 3];
            int k = 2;
            long exp = 4;
            long res = alg.MaximumHappinessSum(happiness, k);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void Test02()
        {
            int[] happiness = [1, 1, 1, 1];
            int k = 2;
            long exp = 1;
            long res = alg.MaximumHappinessSum(happiness, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            int[] happiness = [2, 3, 4, 5];
            int k = 1;
            long exp = 5;
            long res = alg.MaximumHappinessSum(happiness, k);
            Assert.AreEqual(exp, res);
        }
    }
}
