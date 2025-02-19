using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    public class _808_SoupServingsTest
    {
        _808_SoupServingsAlg alg = new _808_SoupServingsAlg();
        public void TestCase01()
        {
            int N = 50;
            double exp = 0.625;
            double res = alg.SoupServings(N);
            Assert.AreEqual(exp, res);
        }
        public void TestCase02()
        {
            int N = 100;
            double exp = 0.71875;
            double res = alg.SoupServings(N);
            Assert.AreEqual(exp, res);
        }
    }
}
