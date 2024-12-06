

select a.stock_name,sum(b.price-a.price) as capital_gain_loss from
(select stock_name,price,
 rank() over( order by stock_name,operation_day asc) as id 
 from Stocks 
 where operation='Buy' order by operation_day asc) a
inner join (
select stock_name,price,
	rank() over( order by stock_name,operation_day asc) as id 
	from Stocks where operation='Sell' 
	order by operation_day asc) b 
	on  a.stock_name=b.stock_name and a.id=b.id
	group by a.stock_name