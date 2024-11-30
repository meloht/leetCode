
select  a.product_id, (select b.new_price from Products b where  b.product_id=a.product_id and change_date<='2019-08-16' order by DATEDIFF('2019-08-16',b.change_date) asc limit 1) as price 
from (select product_id from Products  where  change_date<='2019-08-16' group by product_id) a
union
select product_id,10 as price from Products where product_id in(select product_id  from Products group by product_id having(min(change_date)>'2019-08-16' ))


select p1.product_id, ifnull(p2.new_price, 10) as price
from (
    select distinct product_id
    from products
) as p1 -- 所有的产品
left join (
    select product_id, new_price 
    from products
    where (product_id, change_date) in (
        select product_id, max(change_date)
        from products
        where change_date <= '2019-08-16'
        group by product_id
    )
) as p2 -- 在 2019-08-16 之前有过修改的产品和最新的价格
on p1.product_id = p2.product_id

