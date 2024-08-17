using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _478_GenerateRandomPointInACircleTest
    {
        [TestMethod]
        public void TestCase01()
        {
            _478_GenerateRandomPointInACircleAlg.Solution solution = new _478_GenerateRandomPointInACircleAlg.Solution(1.0, 0.0, 0.0);
            var res1 = solution.RandPoint();//返回[-0.02493，-0.38077]
            double[] exp1 = [-0.02493, -0.38077];
            Assert.IsTrue(exp1.SequenceEqual(exp1));

            res1 = solution.RandPoint();//返回[0.82314,0.38945]
            exp1 = [0.82314, 0.38945];
            Assert.IsTrue(exp1.SequenceEqual(exp1));

            res1 = solution.RandPoint();//返回[0.36572,0.17248]
            exp1 = [0.36572, 0.17248];
            Assert.IsTrue(exp1.SequenceEqual(exp1));
        }
    }
}
