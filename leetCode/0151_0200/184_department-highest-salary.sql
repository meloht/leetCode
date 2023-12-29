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
