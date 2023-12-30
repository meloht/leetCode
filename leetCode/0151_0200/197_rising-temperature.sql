

select b.id from Weather a, Weather b  
where  datediff( b.recordDate, a.recordDate)=1 and b.temperature>a.temperature