select user_id,case when num=0 or total=0 then 0.00
else round(num::numeric/total,2) end as confirmation_rate 
from (
select a.user_id, 
sum(case when b.action='confirmed' then 1  
else 0 end) as num,
sum(case when b.action is not null then 1 else 0 end) as total
from Signups a 
left join Confirmations b on a.user_id=b.user_id
group by a.user_id) tt