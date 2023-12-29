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
  Employee a ) aa inner join Department b on aa.departmentId=b.id where aa.rank=1


 
 SELECT
    Department.name AS 'Department',
    Employee.name AS '

Employee',
    Salary
FROM
    Employee
        JOIN
    Department ON Employee.DepartmentId = Department.Id
WHERE
    (Employee.DepartmentId , Salary) IN
    (   SELECT
            DepartmentId, MAX(Salary)
        FROM
            Employee
        GROUP BY DepartmentId
    )
;


