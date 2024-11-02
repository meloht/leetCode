using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _554_BrickWallAlg
    {
        public int LeastBricks(IList<IList<int>> wall)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
        
            for (int i = 0; i < wall.Count; i++)
            {
                int sum = 0;
                for (int j = 0; j < wall[i].Count-1; j++)
                {
                    sum += wall[i][j];
                    if (dict.ContainsKey(sum))
                    {
                        dict[sum]++;
                    }
                    else
                    {
                        dict.Add(sum, 1);
                    }
                }

            }
            int ans = wall.Count;
            if (dict.Count > 0)
            {
                ans = ans - dict.Values.Max();
            }

            return ans;
        }
    }
}
