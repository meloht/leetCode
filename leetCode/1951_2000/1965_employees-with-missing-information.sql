
select employee_id from (
select a.employee_id from Employees a 
left join Salaries b on a.employee_id=b.employee_id where b.employee_id is null
union
select c.employee_id from Employees a 
right join Salaries c on a.employee_id=c.employee_id where  a.employee_id is null) tt 
order by employee_id