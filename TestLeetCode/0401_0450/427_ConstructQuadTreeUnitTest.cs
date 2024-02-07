using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _427_ConstructQuadTreeUnitTest
    {
        _427_ConstructQuadTreeAlg alg = new _427_ConstructQuadTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[0, 1], [1, 0]];
            Node node = alg.Construct(grid);
            int?[][] exp = [[0, 1], [1, 0], [1, 1], [1, 1], [1, 0]];
            int?[][] res = alg.Build(node);
           // bool bl = Utils.IsSameArr(exp, res);
           // Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [
                [1, 1, 1, 1, 0, 0, 0, 0], 
                [1, 1, 1, 1, 0, 0, 0, 0], 
                [1, 1, 1, 1, 1, 1, 1, 1],
                [1, 1, 1, 1, 1, 1, 1, 1], 
                [1, 1, 1, 1, 0, 0, 0, 0], 
                [1, 1, 1, 1, 0, 0, 0, 0], 
                [1, 1, 1, 1, 0, 0, 0, 0], 
                [1, 1, 1, 1, 0, 0, 0, 0]];
            Node node = alg.Construct(grid);
            int?[][] exp = [[0, 1], [1, 1], [0, 1], [1, 1], [1, 0], null, null, null, null, [1, 0], [1, 0], [1, 1], [1, 1]];
            int?[][] res = alg.Build(node);
           // bool bl = Utils.IsSameArr(exp, res);
            //Assert.IsTrue(bl);
        }
    }
}
