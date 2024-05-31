using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace leetCode._0351_0400
{
    public class _385_MiniParserAlg
    {
        int index = 0;
        public NestedInteger Deserialize(string s)
        {
            if (s[index] == '[')
            {
                index++;
                NestedInteger ni = new NestedInteger();
                while (s[index] != ']')
                {
                    ni.Add(Deserialize(s));
                    if (s[index] == ',')
                    {
                        index++;
                    }
                }
                index++;
                return ni;
            }
            else
            {
                bool negative = false;
                if (s[index] == '-')
                {
                    negative = true;
                    index++;
                }
                int num = 0;
                while (index < s.Length && char.IsDigit(s[index]))
                {
                    num = num * 10 + s[index] - '0';
                    index++;
                }
                if (negative)
                {
                    num *= -1;
                }
                return new NestedInteger(num);
            }
        }
    }

    public class NestedInteger
    {
        private int? _value = null;
        private IList<NestedInteger> _list = null;
        public NestedInteger()
        { }
        public NestedInteger(int value)
        {
            this._value = value;
        }
        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        public bool IsInteger()
        {
            return _value.HasValue;

        }

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        public int? GetInteger()
        {
            return _value;
        }

        // Set this NestedInteger to hold a single integer.
        public void SetInteger(int value)
        {
            _value = value;
        }

        // Set this NestedInteger to hold a nested list and adds a nested integer to it.
        public void Add(NestedInteger ni)
        {
            if (ni.IsInteger())
            {
                SetInteger(ni.GetInteger().Value);
            }
            else
            {
                _list = ni.GetList();
            }
        }

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        public IList<NestedInteger> GetList()
        {
            return _list;
        }


    }
}
