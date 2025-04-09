using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0851_0900._900_RleIteratorAlg;

namespace Testx._0851_0900
{
    public class _900_RleIteratorTest
    {
       

        [Fact]
        public void Test01()
        {
            RLEIterator rLEIterator = new RLEIterator([3, 8, 0, 9, 2, 5]); // 这映射到序列 [8,8,8,5,5]。
            Assert.Equal(8, rLEIterator.Next(2)); // 耗去序列的 2 个项，返回 8。现在剩下的序列是 [8, 5, 5]。
            Assert.Equal(8, rLEIterator.Next(1)); // 耗去序列的 1 个项，返回 8。现在剩下的序列是 [5, 5]。
            Assert.Equal(5, rLEIterator.Next(1)); // 耗去序列的 1 个项，返回 5。现在剩下的序列是 [5]。
            Assert.Equal(-1, rLEIterator.Next(2)); // 耗去序列的 2 个项，返回 -1。 这是由于第一个被耗去的项是 5，
        }
    }
}
