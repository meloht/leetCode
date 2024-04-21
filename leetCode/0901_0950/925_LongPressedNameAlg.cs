using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0901_0950
{
    public class _925_LongPressedNameAlg
    {
        public bool IsLongPressedName1(string name, string typed)
        {

            int i = 0;
            int j = 0;
            while (i < typed.Length && j < name.Length)
            {
                int count = 1;
                for (int k = j + 1; k < name.Length; k++)
                {
                    if (name[k] == name[j])
                    {
                        count++;

                    }
                    else
                    {
                        break;
                    }
                }
                if (count > 1)
                {
                    int count1 = 0;
                    for (; i < typed.Length; i++)
                    {
                        if (typed[i] == name[j])
                        {
                            count1++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (count1 < count)
                    {
                        return false;
                    }

                    j += count;

                }
                else
                {
                    if (typed[i] != name[j])
                    {
                        return false;
                    }
                    while (i < typed.Length && typed[i] == name[j])
                    {
                        i++;
                    }

                    j++;
                }
            }

            if (i != typed.Length)
            {
                return false;
            }
            if (j != name.Length)
            {
                return false;
            }
            return true;
        }


        public bool IsLongPressedName(string name, string typed)
        {
            int i = 0, j = 0;
            while (j < typed.Length)
            {
                if (i < name.Length && name[i] == typed[j])
                {
                    i++;
                    j++;
                }
                else if (j > 0 && typed[j] == typed[j - 1])
                {
                    j++;
                }
                else
                {
                    return false;
                }
            }
            return i == name.Length;
        }


    }
}
