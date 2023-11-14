using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class ZigzagConversionAlg
    {
        public string Convert(string s, int numRows)
        {

            if (string.IsNullOrEmpty(s))
                return string.Empty;

            if (s.Length == 1 || numRows == 1)
                return s;

            int count = s.Length / (numRows - 1);
            if (s.Length % (numRows - 1) > 0)
            {
                count++;
            }
            string[,] arr = new string[numRows, count];
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    arr[i, j] = string.Empty;
                }
            }

            int num = 0;
            int row = 0;
            int col = 0;
            bool isAdd = true;

            for (int i = 0; i < s.Length; i++)
            {
                num++;

                arr[row, col] = s[i].ToString();
                if (isAdd)
                {
                    if (row < numRows - 1)
                    {
                        row++;
                    }

                }
                else
                {
                    if (row > 0)
                    {
                        row--;
                    }

                }


                if (i == 0)
                {
                    num = 0;
                }
                else
                {
                    if (num == (numRows - 1))
                    {
                        num = 0;
                        if (isAdd)
                        {
                            isAdd = false;
                            row--;
                        }
                        else
                        {
                            isAdd = true;
                            row++;
                        }

                        col++;

                    }

                }


            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (arr[i, j] != string.Empty)
                    {
                        sb.Append(arr[i, j]);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
