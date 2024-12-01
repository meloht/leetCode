select round( count(*)*100/(select count(*) from ( select customer_id from Delivery group by customer_id) t) ,2  ) as immediate_percentage from
(select min(order_date) as first_date,customer_id from Delivery group by customer_id) tt

inner join (select distinct order_date,customer_id from  Delivery where order_date=customer_pref_delivery_date ) b on tt.first_date=b.order_date and tt.customer_id=b.customer_id;


select round (
    sum(order_date = customer_pref_delivery_date) * 100 /
    count(*),
    2
) as immediate_percentage
from Delivery
where (customer_id, order_date) in (
    select customer_id, min(order_date)
    from delivery
    group by customer_id
)

