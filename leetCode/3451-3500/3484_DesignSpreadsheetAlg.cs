using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3451_3500
{
    public class _3484_DesignSpreadsheetAlg
    {
        public class Spreadsheet
        {
            int[][] dict = new int[26][];
            public Spreadsheet(int rows)
            {
                for (int i = 0; i < 26; i++)
                {
                    dict[i] = new int[rows];
                }
            }

            public void SetCell(string cell, int value)
            {
                int col = cell[0] - 'A';
                int row = int.Parse(cell.Substring(1))-1;
                dict[col][row] = value;
            }

            public void ResetCell(string cell)
            {
                int col = cell[0] - 'A';
                int row = int.Parse(cell.Substring(1))-1;
                dict[col][row] = 0;
            }

            public int GetValue(string formula)
            {
                string[] arr = formula.Substring(1).Split('+');

                return GetNum(arr[0]) + GetNum(arr[1]);
            }

            private int GetNum(string cell)
            {
                if (char.IsLetter(cell[0]))
                {
                    int col = cell[0] - 'A';
                    int row = int.Parse(cell.Substring(1)) - 1;
                    return dict[col][row];
                }

                return int.Parse(cell);
            }
        }

        public class Spreadsheet1
        {
            private Dictionary<string, int> cellValues = new Dictionary<string, int>();

            public Spreadsheet1(int size) { }

            public void SetCell(string cell, int value)
            {
                cellValues[cell] = value;
            }

            public void ResetCell(string cell)
            {
                cellValues.Remove(cell);
            }

            public int GetValue(string formula)
            {
                int i = formula.IndexOf('+');
                string cell1 = formula.Substring(1, i - 1);
                string cell2 = formula.Substring(i + 1);
                int val1 = char.IsLetter(cell1[0]) ? cellValues.GetValueOrDefault(cell1) : int.Parse(cell1);
                int val2 = char.IsLetter(cell2[0]) ? cellValues.GetValueOrDefault(cell2) : int.Parse(cell2);
                return val1 + val2;
            }
        }

    }
}
