select request_at as Day,Round(count/total,2) as 'Cancellation Rate' from( select a.request_at,count(id) as total,(select count(*) from trips aa
inner join users b on aa.client_id=b.users_id 
inner join users c on aa.driver_id=c.users_id
where b.banned='No' and c.banned= 'No' and (aa.status='cancelled_by_client' or aa.status='cancelled_by_driver')
 and  aa.request_at=a.request_at) as count from trips a 
inner join users b on a.client_id=b.users_id 
inner join users c on a.driver_id=c.users_id
where b.banned='No' and c.banned= 'No' and
 a.request_at between '2013-10-01' and '2013-10-03' group by a.request_at) t


 select request_at as Day,Round(count/total,2) as 'Cancellation Rate' from (
 select a.request_at,count(a.id) as total,sum( case when a.status='cancelled_by_client' or a.status='cancelled_by_driver' then 1 else 0 end) as count
 from trips a 
inner join users b on a.client_id=b.users_id 
inner join users c on a.driver_id=c.users_id
where b.banned='No' and c.banned= 'No' and
 a.request_at between '2013-10-01' and '2013-10-03' group by a.request_at) t
