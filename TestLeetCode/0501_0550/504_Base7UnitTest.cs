using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _504_Base7UnitTest
    {
        _504_Base7Alg alg = new _504_Base7Alg();

        [TestMethod]
        public void TestCase01()
        {
            int num = 100;
            string exp = "202";
            string res = alg.ConvertToBase7(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int num = -7;
            string exp = "-10";
            string res = alg.ConvertToBase7(num);
            Assert.AreEqual(exp, res);
        }
    }
}
