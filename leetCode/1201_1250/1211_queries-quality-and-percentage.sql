
select query_name,round(sum(quality)/count(quality),2)  as quality,
round((sum(case when rating<3 then 1 else 0 end )*100)::numeric /count(quality),2) as poor_query_percentage 
from (select query_name,rating::numeric/position::numeric as quality ,rating from Queries where query_name is not null) tt group by query_name



SELECT 
    query_name, 
    ROUND(AVG(rating/position), 2) quality,
    ROUND(SUM(IF(rating < 3, 1, 0)) * 100 / COUNT(*), 2) poor_query_percentage
FROM Queries
Where query_name IS NOT NULL
GROUP BY query_name

