using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _341_FlattenNestedListIteratorAlg
    {
        public class NestedIterator
        {
            Stack<Tuple<NestedInteger, int>> stack = new Stack<Tuple<NestedInteger, int>>();
            IList<NestedInteger> _nestedList;
            public NestedIterator(IList<NestedInteger> nestedList)
            {
                _nestedList = nestedList;
                stack.Push(new Tuple<NestedInteger, int>(_nestedList[0], 0));
            }

            public bool HasNext()
            {
                if (stack.Count > 0)
                {
                    return true;
                }
                return false;
            }

            public int Next()
            {
                var item=stack.Peek();
                if (item.Item1.IsInteger()) 
                {
                    stack.Pop();
                  
                    return item.Item1.GetInteger();
                }
                   
                return 0;
            }
        }

        public interface NestedInteger
        {
            // @return true if this NestedInteger holds a single integer, rather than a nested list.
            bool IsInteger();

            // @return the single integer that this NestedInteger holds, if it holds a single integer
            // Return null if this NestedInteger holds a nested list
            int GetInteger();

            // @return the nested list that this NestedInteger holds, if it holds a nested list
            // Return null if this NestedInteger holds a single integer
            IList<NestedInteger> GetList();



        }

        public class NestedIntegerImpl : NestedInteger
        {
            private int num;
            private List<NestedInteger> list;
            private bool isNum = false;

            public NestedIntegerImpl(int n)
            {
                isNum = true;
                num = n;
            }
            public NestedIntegerImpl(int n, bool bl)
            {
                isNum = bl;
                num = n;
            }
            public NestedIntegerImpl(int[] ns)
            {
                isNum = false;
                list = new List<NestedInteger>(ns.Length);
                foreach (var item in ns)
                {
                    list.Add(new NestedIntegerImpl(item, false));
                }
            }
            public int GetInteger()
            {
                return num;
            }

            public IList<NestedInteger> GetList()
            {
                return list;
            }

            public bool IsInteger()
            {
                return isNum;
            }

            public static NestedInteger Build(int num)
            {
                NestedIntegerImpl nestedInteger = new NestedIntegerImpl(num);
                return nestedInteger;
            }

            public static NestedInteger Build(int[] nums)
            {
                NestedIntegerImpl nestedInteger = new NestedIntegerImpl(nums);
                return nestedInteger;
            }
        }

    }
}
