

	select visited_on,amount ,ROUND(amount/7, 2) AS average_amount  from (
	
	select visited_on, sum(amount) over(ORDER BY visited_on RANGE '6 days' PRECEDING) as amount from 
	(select visited_on,sum(amount) as amount  from Customer group by visited_on order by visited_on) tt) ttt 
	where visited_on>(select min(visited_on) from Customer)+interval '5 day'