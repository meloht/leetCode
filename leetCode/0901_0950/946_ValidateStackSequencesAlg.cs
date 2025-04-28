using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _946_ValidateStackSequencesAlg
    {
        public bool ValidateStackSequences1(int[] pushed, int[] popped)
        {
            Stack<int> st = [];

            for (int i = 0, j = 0; i < pushed.Length || j < popped.Length;)
            {
                if (i < pushed.Length && j < popped.Length)
                {
                    if (pushed[i] == popped[j])
                    {
                        i++;
                        j++;
                    }
                    else if (st.Count > 0 && st.Peek() == popped[j])
                    {
                        st.Pop();
                        j++;
                    }
                    else
                    {
                        st.Push(pushed[i]);
                        i++;
                    }
                }
                else if (j < popped.Length)
                {
                    if (st.Count > 0 && st.Peek() == popped[j])
                    {
                        st.Pop();
                        j++;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }


            }
            return st.Count == 0;
        }

        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            Stack<int> st = [];

            for (int i = 0, j = 0; i < pushed.Length; i++)
            {
                st.Push(pushed[i]);
                while (st.Count > 0 && st.Peek() == popped[j])
                {
                    st.Pop();
                    j++;
                }

            }
            return st.Count == 0;
        }
    }
}
