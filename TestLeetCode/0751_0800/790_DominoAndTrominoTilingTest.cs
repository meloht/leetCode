using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _790_DominoAndTrominoTilingTest
    {
        _790_DominoAndTrominoTilingAlg alg = new _790_DominoAndTrominoTilingAlg();

        [TestMethod]
        public void TestCase01()
        {
            int N = 3;
            int exp = 5;
            int res = alg.NumTilings(N);
            Console.WriteLine(res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int N = 1;
            int exp = 1;
            int res = alg.NumTilings(N);
            Console.WriteLine(res);
        }
       
    }
}
