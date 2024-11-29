select tt.product_id,tt.first_year,a.quantity,a.price from 
(select product_id,min(year)as first_year  from Sales group by product_id) tt 
inner join Sales a on tt.product_id=a.product_id and tt.first_year=a.year