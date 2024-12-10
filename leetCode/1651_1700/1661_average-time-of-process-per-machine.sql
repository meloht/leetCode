

select machine_id,
round( sum( case activity_type 
when 'start' then -timestamp
else timestamp end )::numeric/count(distinct process_id),3) as processing_time 
from Activity group by machine_id