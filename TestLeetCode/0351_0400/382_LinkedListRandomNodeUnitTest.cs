using leetCode;
using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _382_LinkedListRandomNodeUnitTest
    {


        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3];
            var head = ListNode.BuildListNode(nums);
            _382_LinkedListRandomNodeAlg alg = new _382_LinkedListRandomNodeAlg(head);
            alg.GetRandom();

        }
    }
}
