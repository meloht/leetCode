using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0051_0100
{
    [TestClass]
    public class _79_WordSearchUnitTest
    {
        _79_WordSearchAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _79_WordSearchAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            char[][] arr =new char[][] { ['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E'] };
          
            var res = alg.Exist(arr, "ABCCED");
          
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            char[][] arr = new char[][] { ['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E'] };

            var res = alg.Exist(arr, "SEE");

            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            char[][] arr = new char[][] { ['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E'] };

            var res = alg.Exist(arr, "ABCB");

            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            char[][] arr = new char[][] { ['a', 'b'], ['c', 'd'] };

            var res = alg.Exist(arr, "bacd");

            Assert.AreEqual(true, res);
        }
    }
}
