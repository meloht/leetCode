

select person_name from 
(select a.turn, a.person_id,a.person_name,a.weight,(select sum(tt.weight) from Queue tt where tt.turn<=a.turn) as total from Queue a  order by a.turn asc) t where t.total<=1000 order by t.turn desc limit  1;


select person_name
from (
    select *,sum(weight) over(order by turn) as sumWeight
    from Queue
) as t
where sumWeight <= 1000
order by sumWeight desc
limit 1