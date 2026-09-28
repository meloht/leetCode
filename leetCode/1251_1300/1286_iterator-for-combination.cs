using System;
using System.Collections.Generic;
using System.Text;
using static leetCode._0851_0900._853_CarFleetAlg;

namespace leetCode._1251_1300
{
    public class _1286_iterator_for_combination
    {
        public class CombinationIterator
        {
            private int[] _pos;
            private bool _finished;
            private string _s;

            public CombinationIterator(string characters, int combinationLength)
            {
                _s = characters;
                _pos = new int[combinationLength];
                for (int i = 0; i < combinationLength; i++)
                {
                    _pos[i] = i;
                }
                _finished = false;

            }

            public string Next()
            {
                StringBuilder ans = new StringBuilder();
                foreach (var item in _pos)
                {
                    ans.Append(_s[item]);
                }
                int i = -1;
                for (int k = _pos.Length - 1; k >= 0; --k)
                {
                    if (_pos[k] != _s.Length - _pos.Length + k)
                    {
                        i = k;
                        break;
                    }
                }
                if (i == -1)
                {
                    _finished = true;
                }
                else
                {
                    ++_pos[i];
                    for (int j = i + 1; j < _pos.Length; ++j)
                    {
                        _pos[j] = _pos[j - 1] + 1;
                    }
                }
                return ans.ToString();

            }

            public bool HasNext()
            {
                return !_finished;
            }
        }
    }
}
