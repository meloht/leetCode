using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _799_ChampagneTowerAlg
    {
        public double ChampagneTower(int poured, int query_row, int query_glass)
        {
            double[] row = [poured];

            for (int i = 1; i <= query_row; i++)
            {
                double[] nextRow = new double[i+1];
                for (int j = 0; j < i; j++)
                {
                    double val = row[j];
                    if (val > 1)
                    {
                        nextRow[j] += (val - 1) / 2;
                        nextRow[j + 1] += (val - 1) / 2;
                    }
                }
                row = nextRow;
            }

            return Math.Min(1, row[query_glass]);
        }
    }
}
