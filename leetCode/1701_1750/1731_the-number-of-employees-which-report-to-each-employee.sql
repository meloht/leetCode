

select b.employee_id,b.name,count(a.employee_id) as reports_count,round(avg(a.age),0)as average_age  from Employees a 
inner join Employees b on a.reports_to=b.employee_id
group by b.employee_id,b.name 
order by b.employee_id