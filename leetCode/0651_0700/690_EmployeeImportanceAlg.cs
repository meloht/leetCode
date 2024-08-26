using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _690_EmployeeImportanceAlg
    {
        private Dictionary<int, Employee> dict = new Dictionary<int, Employee>();
        public int GetImportance(IList<Employee> employees, int id)
        {


            foreach (var item in employees)
            {
                dict.Add(item.id, item);
            }
            var emp = dict[id];
            var sub = emp.subordinates;
            int ans = emp.importance;

            if (sub == null)
                return ans;

            foreach (var item in sub)
            {
                var empl = dict[item];
                ans += Dfs(empl);
            }
            return ans;
        }

        private int Dfs(Employee employee)
        {
            if (employee == null)
            {
                return 0;
            }
            int ans = employee.importance;

            var sub = employee.subordinates;
            if (sub == null)
                return ans;
            foreach (var item in sub)
            {
                var emp = dict[item];
                ans += Dfs(emp);
            }
            return ans;
        }


    }
    public class Employee
    {
        public int id;
        public int importance;
        public IList<int> subordinates;
    }
}
