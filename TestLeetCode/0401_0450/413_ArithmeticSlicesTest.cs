using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _413_ArithmeticSlicesTest
    {
        _413_ArithmeticSlicesAlg alg = new _413_ArithmeticSlicesAlg();
        
        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4];
            int exp = 3;
            int res=alg.NumberOfArithmeticSlices(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1,];
            int exp = 0;
            int res = alg.NumberOfArithmeticSlices(nums);
            Assert.AreEqual(exp, res);
        }

    }
}
