

select b.product_name,sum(unit) as unit from Orders a inner join Products b on a.product_id=b.product_id 
where a.order_date >='2020-02-01' and a.order_date< '2020-03-01' 
group by b.product_name having (sum(unit)>=100)