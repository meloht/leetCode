select a.`name` as `Employee` 
from Employee a inner join Employee b on b.id=a.managerId where a.managerId is not null and a.salary>b.salary