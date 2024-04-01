using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0301_0350._341_FlattenNestedListIteratorAlg;

namespace Test._0301_0350
{
    [TestClass]
    public class _341_FlattenNestedListIteratorUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            IList<NestedInteger> nestedList = new List<NestedInteger>();
            nestedList.Add(NestedIntegerImpl.Build([1, 1]));
            nestedList.Add(NestedIntegerImpl.Build(2));
            nestedList.Add(NestedIntegerImpl.Build([1, 1]));
            _341_FlattenNestedListIteratorAlg.NestedIterator alg = new NestedIterator(nestedList);
            int[] exp = [1, 1, 2, 1, 1];
            List<int> res = new List<int>();
            while (alg.HasNext())
            {
                res.Add(alg.Next());
            }

            Assert.IsTrue(exp.SequenceEqual(res.ToArray()));
        }


        [TestMethod]
        public void TestCase02()
        {
            IList<NestedInteger> nestedList = new List<NestedInteger>();
            nestedList.Add(NestedIntegerImpl.Build([]));
            nestedList.Add(NestedIntegerImpl.Build(3));
   
            _341_FlattenNestedListIteratorAlg.NestedIterator alg = new NestedIterator(nestedList);
            int[] exp = [3];
            List<int> res = new List<int>();
            while (alg.HasNext())
            {
                res.Add(alg.Next());
            }

            Assert.IsTrue(exp.SequenceEqual(res.ToArray()));
        }

        [TestMethod]
        public void TestCase03()
        {
            IList<NestedInteger> nestedList = new List<NestedInteger>();
            nestedList.Add(NestedIntegerImpl.Build(3));
            nestedList.Add(NestedIntegerImpl.Build([]));

            _341_FlattenNestedListIteratorAlg.NestedIterator alg = new NestedIterator(nestedList);
            int[] exp = [3];
            List<int> res = new List<int>();
            while (alg.HasNext())
            {
                res.Add(alg.Next());
            }

            Assert.IsTrue(exp.SequenceEqual(res.ToArray()));
        }





    }
}
