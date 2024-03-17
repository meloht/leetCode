using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _528_RandomPickWithWeightUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            _528_RandomPickWithWeightAlg.Solution solution = new _528_RandomPickWithWeightAlg.Solution([1]);
            int res = solution.PickIndex();
            Assert.AreEqual(0, res);
        }

       
    }
}
