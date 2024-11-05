

select c.name from Employee c inner join (select a.id from Employee a inner join Employee b on a.id=b.managerid 
where b.managerid is not null group by a.id having count(a.id)>=5) t on c.id=t.id