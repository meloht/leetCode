
 select max(salary) as SecondHighestSalary from employee where salary<(select max(salary) from employee );
 
 select (select distinct salary from Employee order by salary desc limit 1,1) as SecondHighestSalary;
 SELECT
    IFNULL(
      (SELECT DISTINCT Salary
       FROM Employee
       ORDER BY Salary DESC
        LIMIT 1 OFFSET 1),
    NULL) AS SecondHighestSalary

