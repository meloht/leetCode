
select CONVERT((select count(aa.player_id) from Activity aa inner join 
(select player_id, adddate(min(event_date),interval 1 day) as event_date from Activity group by player_id) tt on aa.player_id=tt.player_id and aa.event_date=tt.event_date
)/(select count(distinct player_id) from Activity ),DECIMAL(15,2)) AS fraction