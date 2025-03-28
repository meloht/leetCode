using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _841_KeysAndRoomsAlg
    {

        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            HashSet<int> visited = new HashSet<int>();
            Dfs(rooms, 0, visited);
            return visited.Count == rooms.Count;
        }

        private void Dfs(IList<IList<int>> rooms, int i, HashSet<int> visited)
        {
            if (visited.Contains(i))
                return;

            visited.Add(i);

            var list = rooms[i];
            foreach (var item in list)
            {
                Dfs(rooms, item, visited);
            }
        }
    }
}
