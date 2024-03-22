using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _284_PeekingIteratorAlg
    {
        public class PeekingIterator
        {
            bool flag = false;
            IEnumerator<int> enumerator;
            // iterators refers to the first element of the array.
            public PeekingIterator(IEnumerator<int> iterator)
            {
                enumerator = iterator;

                flag = enumerator.MoveNext();
            }

            // Returns the next element in the iteration without advancing the iterator.
            public int Peek()
            {
                return this.enumerator.Current;

            }

            // Returns the next element in the iteration and advances the iterator.
            public int Next()
            {
                int res = this.enumerator.Current;
                flag = this.enumerator.MoveNext();
                return res;

            }

            // Returns false if the iterator is refering to the end of the array of true otherwise.
            public bool HasNext()
            {
                return flag;
            }
        }
    }
}
