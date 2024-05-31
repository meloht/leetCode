using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _385_MiniParserUnitTest
    {
        _385_MiniParserAlg alg = new _385_MiniParserAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "324";
            NestedInteger res = alg.Deserialize(s);
            Assert.AreEqual(res.GetInteger().Value, 324);
        }
    }
}
