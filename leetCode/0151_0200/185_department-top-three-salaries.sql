

select aa.name as Employee, aa.salary, b.name as Department 
from
(SELECT
  a.salary,a.departmentId,a.name,
  DENSE_RANK() OVER (
  partition by a.departmentId
    ORDER BY
      a.salary DESC
  ) AS 'rank'
FROM
  Employee a ) aa inner join Department b on aa.departmentId=b.id where aa.rank<=3


  SELECT
    d.Name AS 'Department', e1.Name AS 'Employee', e1.Salary
FROM
    Employee e1
        JOIN
    Department d ON e1.DepartmentId = d.Id
WHERE
    3 > (SELECT
            COUNT(DISTINCT e2.Salary)
        FROM
            Employee e2
        WHERE
            e2.Salary > e1.Salary
                AND e1.DepartmentId = e2.DepartmentId
        )
;


