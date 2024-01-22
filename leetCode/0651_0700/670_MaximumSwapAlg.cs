using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _670_MaximumSwapAlg
    {
        public int MaximumSwap1(int num)
        {
            var n = num.ToString();
            if (n.Length == 1)
                return num;

            var nn = n.ToCharArray();
            int index = 0;
            while (index < n.Length)
            {
                int j = 0;
                char firstNum= nn[index];
                char max = '0';
                for (int i = index; i < n.Length; i++)
                {
                    if (n[i] >= max)
                    {
                        max = n[i];
                        j = i;
                    }
                }
                if (firstNum == max)
                {
                    index++;
                }
                else if (index == n.Length - 1)
                {
                    break;
                }
                else
                {
                    char first = n[index];
                    nn[index] = nn[j];
                    nn[j] = first;
                    string ss = new string(nn);
                    return int.Parse(ss);
                }
            }


            return num;
        }


        public int MaximumSwap2(int num)
        {
            char[] charArray = num.ToString().ToCharArray();
            int n = charArray.Length;
            int maxNum = num;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    Swap(charArray, i, j);
                    maxNum = Math.Max(maxNum, int.Parse(new string(charArray)));
                    Swap(charArray, i, j);
                }
            }
            return maxNum;
        }

        public void Swap(char[] charArray, int i, int j)
        {
            char temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
        }

        public int MaximumSwap(int num)
        {
            char[] charArray = num.ToString().ToCharArray();
            int n = charArray.Length;
            int maxIdx = n - 1;
            int idx1 = -1, idx2 = -1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (charArray[i] > charArray[maxIdx])
                {
                    maxIdx = i;
                }
                else if (charArray[i] < charArray[maxIdx])
                {
                    idx1 = i;
                    idx2 = maxIdx;
                }
            }
            if (idx1 >= 0)
            {
                Swap(charArray, idx1, idx2);
                return int.Parse(new string(charArray));
            }
            else
            {
                return num;
            }
        }




    }
}
