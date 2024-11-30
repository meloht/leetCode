select b.user_id as buyer_id,b.join_date,case when a.orders_in_2019 is null then 0 else a.orders_in_2019 end as orders_in_2019  from Users b left join
(select buyer_id,count(order_id) as orders_in_2019  from  Orders   where order_date between '2019-01-01' and  '2019-12-31' group by buyer_id) a
on a.buyer_id=b.user_id